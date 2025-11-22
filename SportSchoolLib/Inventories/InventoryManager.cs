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
            if (string.IsNullOrEmpty(inventory.Name_Inventory))
            {
                return "Введите наименование инвентаря";
            }
            if (inventory.Count_Inventory == 0 || inventory.Count_Inventory < 0)
            {
                return "Введите корректное количество инвентаря";
            }

            storage_.AddInventory(inventory);
            return "Новая запись успешно добавлена";
        }
        public string EditInventory(Inventory inventory)
        {
            return "";
        }
    }
}
