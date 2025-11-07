using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSchoolLib
{
    public class InstructorManager
    {
        private IInstructorManager storage_;
        public InstructorManager(IInstructorManager storage)
        {
            storage_ = storage;
        }

        public string AddInstructor(Instructor instructor)
        {
            return "";
        }
        // входной параметр типа Instructor,
        //содержащий данныет тренера (ФИО, квалификацию, телефон, секцию)

        // выходные данные: строка сообщающая об успехе или ошибке добавления тренера

        public string DeleteInstructor(Instructor instructor)
        {
            return "бебебе";
        }
    }
}
