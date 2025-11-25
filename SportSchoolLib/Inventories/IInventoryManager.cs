using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSchoolLib.Inventors
{
    public interface IInventoryManager
    {
        string AddInventory(Inventory inventory);
        string UpdateInventory(Inventory inventory);
    }
}
