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
        private MySQLTraineeManager traineeManager;

        public TraineeDBManager(IStorageTrainee storage)
        {
            storage_ = storage;
        }

        public TraineeDBManager(MySQLTraineeManager traineeManager)
        {
            this.traineeManager = traineeManager;
        }

        public string AddTrainee(Trainee trainee)
        {
            if (string.IsNullOrEmpty(trainee.FIO))
            {
                return "Введите ФИО ученика";
            }
            if (storage_ != null)
            {
                if (storage_.Id_TraineeExists(trainee.Id_Trainee))
                {
                    return $"Ученик с ID ^{trainee.Id_Trainee}^ уже существует";
                }
                storage_.AddTrainee(trainee);
                return "Ученик успешно добавлен";
            }
            else if (traineeManager != null)
            {
                return traineeManager.AddTrainee(trainee);
            }

            return "Ошибка: менеджер данных не инициализирован";
        }
    }
}
