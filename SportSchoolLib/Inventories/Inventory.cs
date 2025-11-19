using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSchoolLib
{
    public class Inventory
    {
        public int Id_Inventory { get; } // id инвентаря 
        public string Name_Inventory { get; set; } // наименование инвентаря 
        public int Count_Inventory { get; set; }// количество инвентаря
        public DateTime DateDelivery { get; set; } // дата поставки инвентаря
        public Inventory() { }
        public Inventory(int Id)
        {
            Id_Inventory = Id;
        }
    }
}
