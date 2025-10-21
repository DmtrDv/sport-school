using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSchoolLib
{
    public class TraineeDBManager
    {
        private IStorageTrainee storage_;

        public TraineeDBManager(IStorageTrainee storage)
        {
            storage_ = storage;
        }
        public string AddTrainee(Trainee trainee)
        {
            if (string.IsNullOrEmpty(trainee.FIO))
            {
                return "Введите ФИО ученика";
            }
            if(trainee.Birthday.Month >12)
            {
                return "Введите правильную дату";
            }
            if (!Enum.IsDefined(typeof(section), trainee.Section))
            {
                return "Выберите одну из существующих секций";
            }
            if (!Enum.IsDefined(typeof(category), trainee.Category))
            {
                return "Выберите один из существующих разрядов";
            }
            if (string.IsNullOrEmpty(trainee.FIOParent))
            {
                return "Введите ФИО родителя";
            }
            if (string.IsNullOrEmpty(trainee.PhoneNumberParent))
            {
                return "Введите номер телефона родителя";
            }
            if (storage_ != null)
            {
                if (storage_.Id_TraineeExists(trainee.Id_Trainee))
                {
                    return "Такой ID ученика уже существует";
                }
                storage_.AddTrainee(trainee);
            }
            return "Ученик успешно добавлен";
        }
    }
}
