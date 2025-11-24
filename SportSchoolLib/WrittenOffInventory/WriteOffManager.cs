using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSchoolLib.WrittenOffInventory
{
    public class WriteOffManager
    {
        private IWriteOffManager storage_;

        public WriteOffManager(IWriteOffManager storage)
        {
            storage_ = storage;
        }

        public string WriteOffInventory(Inventory inventory, int writeOffCount)
        {
            if (writeOffCount <= 0)
                return "Количество для списания должно быть больше 0";

            if (writeOffCount > inventory.Count_Inventory)
                return $"Нельзя списать больше {inventory.Count_Inventory} единиц инвентаря";

            return storage_.WriteOffInventory(inventory, writeOffCount);
        }
    }
}
