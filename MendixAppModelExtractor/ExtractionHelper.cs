using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace MendixAppModelExtractor {
  class ExtractionHelper {
    private Stream projectStream;

    public ExtractionHelper(Stream projectStream) {
      this.projectStream = projectStream;
      Directory.CreateDirectory(@".\tmp\database");
      var databaseFileStream = File.OpenWrite(@".\tmp\database");

      byte[] buffer = new byte[8 * 1024];
      int len;
      while ((len = projectStream.Read(buffer, 0, buffer.Length)) > 0) {
        databaseFileStream.Write(buffer, 0, len);
      }

      SQLiteConnection connection = new SQLiteConnection(@".\tmp\database");
      Console.WriteLine(connection.FileName);
    }
  }
}
