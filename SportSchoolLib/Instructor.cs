using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSchoolLib
{
    public class Instructor
    {
        public int Id_Instructor { get; } // id тренера представлено целочисленным значением
        public string FIO_Instructor { get; set; } // ФИО тренера представлено строковым значением
        public qualification Qualification { get; set; } // квалификация тренера представлена перечислением
        public string PhoneNumberInstructor { get; set; } // номер телефона тренера представлен строковым значением
        public section Section{ get; set; } // секция в которой тренер преподаёт представлена перечислением
    }
    public enum qualification
    {
        Первая,
        Вторая,
        Высшая
    }
}
