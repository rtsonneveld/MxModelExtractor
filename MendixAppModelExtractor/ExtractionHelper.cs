using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using Newtonsoft.Json;
using MendixAppModelExtractor.MendixProject;

namespace MendixAppModelExtractor {
  class ExtractionHelper {
    private Stream projectStream;
    private String productVersion;
    private SQLiteConnection dbConnection;
    private string packageName;

    private List<MxUnit> units;

    public ExtractionHelper(string packageName, Stream projectStream) {
      this.packageName = packageName;
      this.projectStream = projectStream;
    }

    public void Init() {

      #region Copy database from zip into a new file (tmp/database.sqlite)

      Directory.CreateDirectory(@".\tmp\database");
      try {
        using (FileStream databaseFileStream = File.OpenWrite(@".\tmp\database.sqlite")) {

          byte[] buffer = new byte[8 * 1024];
          int len;
          while ((len = projectStream.Read(buffer, 0, buffer.Length)) > 0) {
            databaseFileStream.Write(buffer, 0, len);
          }

          databaseFileStream.Close();
        }
      } catch (IOException exception) {
        Console.WriteLine(exception.ToString());
        MessageBox.Show("An error occurred while creating the database file: " + Environment.NewLine + exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      #endregion

      #region Read data from the database
      // Set up connection with SQLite
      try {
        using (this.dbConnection = new SQLiteConnection(@"Data Source = .\tmp\database.sqlite")) {
          this.dbConnection.Open();
          this.Read();
        }
      } catch (SQLiteException exception) {
        Console.WriteLine(exception.ToString());
        MessageBox.Show("An error occurred while opening the database: " + Environment.NewLine + exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      #endregion

    }

    void Read() {
      // Initialize variables
      SQLiteCommand command = null;
      SQLiteDataReader reader = null;

      #region Read Product Version
      string sql_getProductVersion = "select _ProductVersion from _MetaData";
      using (command = new SQLiteCommand(sql_getProductVersion, this.dbConnection)) {
        using (reader = command.ExecuteReader()) {

          reader.Read();
          this.productVersion = reader.GetString(0);
          Console.WriteLine("Product Version = {0}", this.productVersion);

        }
      }
      #endregion

      #region Read Unit Objects

      units = new List<MxUnit>();
      string exportPath = "./export/" + packageName + "/";

      // Delete current export directory
      if (Directory.Exists(exportPath)) {
        Directory.Delete(exportPath, true);
      }

      string sql_getUnitObjects = "select * from Unit";
      using (command = new SQLiteCommand(sql_getUnitObjects, this.dbConnection)) {
        using (reader = command.ExecuteReader()) {

          while (reader.Read()) {

            MxUnit mxUnit = new MxUnit();

            #region Fill MxUnit from database record
            byte[] unitID             = (byte[])  reader["UnitID"];
            byte[] containerID        = (byte[])  reader["ContainerID"];
            string containmentName    = (string)  reader["ContainmentName"];
            long treeConflict         = (long)    reader["TreeConflict"];
            string contentsHash       = (string)  reader["ContentsHash"];
            string contentsConflicts  = (string)  reader["ContentsConflicts"];
            byte[] contents           = (byte[])  reader["Contents"];

            mxUnit.UnitID             = unitID;
            mxUnit.ContainerID        = containerID;

            Enum.TryParse<ContainmentName>(containmentName, out mxUnit.ContainmentName);
            mxUnit.TreeConflict       = treeConflict;
            mxUnit.ContentsHash       = contentsHash;
            mxUnit.ContentsConflicts  = contentsConflicts;
            mxUnit.Contents           = contents;
            #endregion

            Contents contentsObj = mxUnit.getContentsAsJson();
            string name = (contentsObj.Name == null) ? "" : contentsObj.Name.Replace('/','_');
            string type = contentsObj.Type;

            // Create a new one
            Directory.CreateDirectory(exportPath+type+"/");

            FileStream exportFile = File.Create(exportPath+type+"/"+name+"_"+mxUnit.GetUnitID()+".json");
            string jsonString = mxUnit.getContentsAsJsonString();
            exportFile.Write(Encoding.ASCII.GetBytes(jsonString), 0, jsonString.Length);
            exportFile.Flush();
            exportFile.Close();

            Console.WriteLine("Read element " + mxUnit+", name = "+name+", type = "+type);
          }

        }
      }

      var infoFile = File.Create(exportPath + "info.json");
      var info = new ProjectInfo();
      info.productVersion = productVersion;
      info.productName = packageName;

      string infoString = JsonConvert.SerializeObject(info);
      infoFile.Write(Encoding.ASCII.GetBytes(infoString), 0, infoString.Length);
      #endregion
    }

  }
}
