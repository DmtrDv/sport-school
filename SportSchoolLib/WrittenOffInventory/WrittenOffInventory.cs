using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSchoolLib.WrittenOffInventory
{
    public class WrittenOffInventory
    {
        [DisplayName("ИД")]
        public int Id_WrittenOff { get; set; } //id списания

        [DisplayName("Наименование")]
        public string Name_Inventory { get; set; }//Наименование списания

        [DisplayName("Количество")]
        public int Count_WrittenOff { get; set; }//Количество списываемого

        [DisplayName("Дата списания")]
        public DateTime WriteOffDate { get; set; }//Дата списания

        [DisplayName("ИД исходного инвентаря")]
        public int OriginalInventoryId { get; set; }//ИД исходного инвентаря
    }
}
