using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MendixAppModelExtractor {


  enum ContainmentName {
    NULL,
    Documents,
    DomainModel,
    Folders,
    ImageCollection,
    ModuleSecurity,
    Modules,
    Navigation,
    ProjectConversion,
    ProjectSecurity,
    ProjectDocuments,
    Settings,
    SystemTextCollection
  }

  class Contents {
    public string Name;

    [JsonProperty(PropertyName = "$Type")]
    public string Type;
  }

  class MxUnit {

    public byte[] UnitID;
    public byte[] ContainerID; // Indicates the 'parent' Unit
    public ContainmentName ContainmentName;
    public long TreeConflict;
    public string ContentsHash;
    public string ContentsConflicts;
    public byte[] Contents;

    public override String ToString() {
      uint unitId_int = 0;
      unitId_int = BitConverter.ToUInt32(UnitID, 0);
      return String.Format("MxUnit{{UnitId={0},ContainmentName={1}}}", unitId_int, ContainmentName);
    }

    public uint GetUnitID() {
      return BitConverter.ToUInt32(UnitID, 0);
    }

    public Contents getContentsAsJson() {
      MemoryStream ms = new MemoryStream(this.Contents);

      using (BsonReader reader = new BsonReader(ms)) {
        JsonSerializer serializer = new JsonSerializer();

        Contents deserialized = serializer.Deserialize<Contents>(reader);
        return deserialized;
      }
    }

    public string getContentsAsJsonString() {

      MemoryStream ms = new MemoryStream(this.Contents);

      using (BsonReader reader = new BsonReader(ms)) {
        JsonSerializer serializer = new JsonSerializer();

        dynamic deserialized = serializer.Deserialize(reader);
        deserialized["ContainerId"] = ContainerID;
        return JsonConvert.SerializeObject(deserialized, Formatting.Indented);
      }
    }
  }

  

}
