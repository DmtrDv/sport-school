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
            /*if (string.IsNullOrEmpty(trainee.FIO))
            {
                return "Введите ФИО ученика";
            }*/
            if (storage_ != null)
            {
                if (storage_.Id_TraineeExists(trainee.Id_Trainee))
                {
                    return $"Ученик с ID ^{trainee.Id_Trainee}^ уже существует";
                }
                storage_.AddTrainee(trainee);
            }
            return "Ученик успешно добавлен";
        }
    }
}
