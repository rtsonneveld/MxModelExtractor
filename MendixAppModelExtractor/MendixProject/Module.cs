using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MendixAppModelExtractor.MendixProject {
  public class Module : Container {

    public Module(string id, string name) : base(id, name) {
      this.id = id;
      this.name = name;
    }

    public static Module CreateFromJson(string json) {
      dynamic jsonObject = JsonConvert.DeserializeObject(json);
      string id = jsonObject["$ID"];
      string name = jsonObject["Name"];

      return new Module(id, name);
    }

  }
}
