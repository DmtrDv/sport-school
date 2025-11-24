using SportSchoolLib.WrittenOffInventory;
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
        private IWriteOffManager writeOffStorage_;
        public InventoryManager(IInventoryManager storage)
        {
            storage_ = storage;
        }
        public InventoryManager(IInventoryManager storage, IWriteOffManager writeOffStorage)
        {
            storage_ = storage;
            writeOffStorage_ = writeOffStorage;
        }
        public string AddInventory(Inventory inventory)
        {
            if (string.IsNullOrEmpty(inventory.Name_Inventory))
            {
                return "Введите наименование инвентаря";
            }
            if (inventory.Count_Inventory <= 0)
            {
                return "Введите корректное количество инвентаря";
            }

            storage_.AddInventory(inventory);
            return "Новая запись успешно добавлена";
        }
        public string WriteOffInventory(Inventory inventory, int writeOffCount)
        {
            if (writeOffCount <= 0)
            {
                return "Количество для списания должно быть больше 0";
            }

            if (writeOffCount > inventory.Count_Inventory)
            {
                return $"Нельзя списать больше {inventory.Count_Inventory} единиц инвентаря";
            }
            writeOffStorage_.WriteOffInventory(inventory, writeOffCount);
            return "Инвентарь успешно списан";
        }
    }
}
