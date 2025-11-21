using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSchoolLib
{
    public class Inventory
    {
        [DisplayName("ИД")]
        public int Id_Inventory { get; } // id инвентаря 
        [DisplayName("Наименование")]
        public string Name_Inventory { get; set; } // наименование инвентаря 
        [DisplayName("Количество")]
        public int Count_Inventory { get; set; }// количество инвентаря
        [DisplayName("Дата поставки")]
        public DateTime DateDelivery { get; set; } // дата поставки инвентаря
        public Inventory() { }
        public Inventory(int Id)
        {
            Id_Inventory = Id;
        }
    }
}
