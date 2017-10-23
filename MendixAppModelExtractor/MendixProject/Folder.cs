using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MendixAppModelExtractor.MendixProject {
  public class Folder : Container {

    public Folder(string id, string name) : base(id, name) {
      this.id = id;
      this.name = name;
    }

  }
}
