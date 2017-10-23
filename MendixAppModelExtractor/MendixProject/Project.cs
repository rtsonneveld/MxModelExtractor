using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MendixAppModelExtractor.MendixProject {
  class Project {

    public string name { get; set; }
    public List<Module> moduleList {
      get {
        return new List<Module>(moduleList);
      }
      private set {
        moduleList = value;
      }
    }

    public Project() {
      moduleList = new List<Module>();
    }

    public void addModule(Module module) {
      moduleList.Add(module);
    }

  }
}
