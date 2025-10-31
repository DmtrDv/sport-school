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
            if (string.IsNullOrEmpty(instructor.FIO_Instructor))
            {
                return "Введите ФИО тренера";
            }
            if (!Enum.IsDefined(typeof(qualification), instructor.Qualification))
            {
                return "Выберите квалификацию";
            }
            if (!Enum.IsDefined(typeof(section), instructor.Section))
            {
                return "Выберите секцию";
            }

            return "Новый тренер успешно добавлен";
        }
        // входной параметр типа Instructor,
        //содержащий данныет тренера (ФИО, квалификацию, телефон, секцию)

        // выходные данные: строка сообщающая об успехе или ошибке добавления тренера
    }
}
