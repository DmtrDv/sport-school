using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace SportSchoolLib
{
    public class Trainee
    {
        [DisplayName("ИД")]
        public int Id_Trainee { get; set; }
        [DisplayName("ФИО")]
        public string FIO { get; set; }
        [DisplayName("Дата рождения")]
        public DateTime Birthday { get; set; }
        [DisplayName("Секция")]
        public section Section { get; set; }
        [DisplayName("Разряд")]
        public category Category { get; set; }
        [DisplayName("ФИО родителя")]
        public string FIOParent { get; set; }
        [DisplayName("Телефон родителя")]
        public string PhoneNumberParent { get; set; }
        public Trainee() { }
        public Trainee(int Id)
        {
            Id_Trainee = Id;
        }
    }
    public enum section
    {
        Спортивный_туризм,
        Скалолазание,
        Гребля

    }
    public enum category
    {
        III_юношеский_спортивный_разряд,
        II_юношеский_спортивный_разряд,
        I_юношеский_спортивный_разряд,
        III_спортивный_разряд,
        II_спортивный_разряд,
        I_спортивный_разряд,
        КМС,
        МС,
        отсутствует
    }
}
