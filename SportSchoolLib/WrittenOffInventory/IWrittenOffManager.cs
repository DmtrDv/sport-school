using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportSchoolLib;

namespace SportSchoolLib.WrittenOffInventory
{
    public interface IWriteOffManager
    {
        string WriteOffInventory(Inventory inventory, int writeOffCount);
        List<WrittenOffInventory> GetWrittenOffArchive();
    }
}
