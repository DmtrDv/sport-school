using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace SportSchoolLib
{
    public class Trainee
    {
        public int Id_Trainee { get; set; }
        public string FIO { get; set; }
        public DateTime Birthday { get; set; }
        public section Section { get; set; }
        public category Category { get; set; }
        public string FIOParent { get; set; }
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
        скалолазание,
        гребля

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
