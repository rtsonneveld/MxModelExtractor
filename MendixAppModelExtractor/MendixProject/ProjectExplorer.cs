using MendixAppModelExtractor.MendixProject;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MendixAppModelExtractor {
  public partial class ProjectExplorer : Form {
    public ProjectExplorer(string folder) {
      InitializeComponent();
      LoadProject(folder);
    }

    private void LoadProject(string folder) {
      #region Load project info

      folder = "export/" + folder;

      string infoString = File.ReadAllText(folder + "/info.json");
      ProjectInfo projectInfo = JsonConvert.DeserializeObject<ProjectInfo>(infoString);

      labelProjectInfo.Text = "Project '" + projectInfo.productName + "', MX version " + projectInfo.productVersion;

      #endregion

      #region Load modules

      string[] moduleFiles = null;
      string moduleDir = null; 

      if (Directory.Exists(folder+"/Projects$ModuleImpl")) {
        moduleDir = folder + "/Projects$ModuleImpl"; 
      } else if (Directory.Exists(folder + "/Projects$Module")) {
        moduleDir = folder + "/Projects$Module";
      }

      moduleFiles = Directory.GetFiles(moduleDir);

      foreach (string moduleFile in moduleFiles) {
        Module module = Module.CreateFromJson(File.ReadAllText(moduleFile));
        ModuleList.Items.Add(module);
      }


      #endregion
    }

    private void ModuleList_SelectedIndexChanged(object sender, EventArgs e) {
      
    }
  }
}
