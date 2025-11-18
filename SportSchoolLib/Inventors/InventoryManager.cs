using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSchoolLib.Inventors
{
    public class InventoryManager
    {
        private IInventoryManager storage_;
        public InventoryManager(IInventoryManager storage)
        {
            storage_ = storage;
        }
        public string AddInventory(Inventory inventory)
        {
            return "";
        }
    }
}
