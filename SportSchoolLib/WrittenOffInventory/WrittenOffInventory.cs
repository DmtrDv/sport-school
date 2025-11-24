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
        public int Id_WrittenOff { get; set; }

        [DisplayName("Наименование")]
        public string Name_Inventory { get; set; }

        [DisplayName("Количество")]
        public int Count_WrittenOff { get; set; }

        [DisplayName("Дата списания")]
        public DateTime WriteOffDate { get; set; }

        [DisplayName("ИД исходного инвентаря")]
        public int OriginalInventoryId { get; set; }
    }
}
