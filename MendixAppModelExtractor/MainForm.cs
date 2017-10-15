using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;

namespace MendixAppModelExtractor {
  public partial class MainForm : Form {
    public MainForm() {
      InitializeComponent();
    }

    private void buttonSelectFile_Click(object sender, EventArgs e) {
      var fileDialog = new OpenFileDialog();
      fileDialog.Filter = "Mendix Projects/Packages|*.mpr;*.mpk|All files|*.*";
      if (fileDialog.ShowDialog() != DialogResult.OK) {
        return;
      }

      string packageName = Path.GetFileNameWithoutExtension(fileDialog.FileName);
      string extension = Path.GetExtension(fileDialog.FileName);

      Stream projectStream;

      if (extension.ToLower() == ".mpk") {
        ZipArchiveEntry projectEntry = null;

        try {
          System.IO.Compression.ZipArchive archive = new ZipArchive(fileDialog.OpenFile());
          if (archive.GetEntry(packageName + ".mpr") != null) {
            projectEntry = archive.GetEntry(packageName + ".mpr");
          } else {
            projectEntry = archive.GetEntry("project.mpr");
          }
        } catch (Exception exception) {
          Console.WriteLine(exception.ToString());
        }
        if (projectEntry == null) {
          MessageBox.Show("Please select a valid Mendix Project or Module Package (.mpk)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

        projectStream = projectEntry.Open();
      } else {
        projectStream = File.OpenRead(fileDialog.FileName);
      }

      ExtractionHelper helper = new ExtractionHelper(projectStream);
      helper.Init();
    }
  }
}
