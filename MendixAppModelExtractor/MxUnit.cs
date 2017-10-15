using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MendixAppModelExtractor {


  enum ContainmentName {
    NULL,
    Documents,
    Folders,
    ModuleSecurity,
    Modules,
    ProjectConversion,
    ProjectDocuments,
    DomainModel
  }

  class MxUnit {

    public byte[] UnitID;
    public byte[] ContainerID;
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
  }

}
