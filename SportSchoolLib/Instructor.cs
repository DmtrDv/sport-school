using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSchoolLib
{
    public class Instructor
    {
        public int Id_Instructor { get; } // id 
        public string FIO_Instructor { get; set; } // ФИО 
        public qualification Qualification { get; set; } // квалификация 
        public string PhoneNumberInstructor { get; set; } // номер телефона 
        public section Section{ get; set; } // секция 
    }
    public enum qualification
    {
        Первая,
        Вторая,
        Высшая
    }
}
