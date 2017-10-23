using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MendixAppModelExtractor.MendixProject {

  public class Container {
    public string id { get; set; }
    public string name { get; set; }
    public List<Document> documentList {
      get { return new List<Document>(documentList); }
      private set { documentList = value; }
    }

    protected Container(string id, string name) {
      this.id = id;
      this.name = name;
    }

    public override string ToString() {
      return this.name;
    }
  }
}
