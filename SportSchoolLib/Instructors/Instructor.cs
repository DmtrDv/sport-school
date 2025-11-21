using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSchoolLib
{
    public class Instructor
    {
        [DisplayName("ИД")]
        public int Id_Instructor { get; } // id 
        [DisplayName("ФИО")]
        public string FIO_Instructor { get; set; } // ФИО 
        [DisplayName("Квалификация")]
        public qualification Qualification { get; set; } // квалификация 
        [DisplayName("Номер телефона")]
        public string PhoneNumberInstructor { get; set; } // номер телефона 
        [DisplayName("Секция")]
        public section Section{ get; set; } // секция 

        public Instructor() { }
        public Instructor(int Id) 
        {
            Id_Instructor = Id;
        }
    }
    public enum qualification
    {
        Первая,
        Вторая,
        Высшая
    }
}
