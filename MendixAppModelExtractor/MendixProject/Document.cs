using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MendixAppModelExtractor.MendixProject {
  public class Document {

    Module module;
    string name;

    public Document(Module module, string name) {
      this.module = module;
      this.name = name;
    }
  }
}
