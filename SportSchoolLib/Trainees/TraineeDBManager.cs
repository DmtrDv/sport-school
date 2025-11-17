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
        private List<Trainee> trainees_;
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
                return "Ученик успешно добавлен";
            }
            else if (traineeManager != null)
            {
                return traineeManager.AddTrainee(trainee);
            }

            return "Ошибка: менеджер данных не инициализирован";
        }

        public string DeleteTrainee(int idTrainee, bool userConfirmed = false)
        {
            if (!userConfirmed)
            {
                return "Удаление отменено пользователем";
            }

            if (storage_ != null)
            {
                // Проверяем существование обучающегося
                if (!storage_.Id_TraineeExists(idTrainee))
                {
                    return $"Обучающийся с ID ^{idTrainee}^ не найден";
                }

                // Удаляем обучающегося
                bool isDeleted = storage_.DeleteTrainee(idTrainee);

                if (isDeleted)
                {
                    var traineeToRemove = trainees_.FirstOrDefault(t => t.Id_Trainee == idTrainee);
                    if (traineeToRemove != null)
                    {
                        trainees_.Remove(traineeToRemove);
                    }

                    return "Учащийся успешно удалён";
                }
                else
                {
                    return "Ошибка при удалении учащегося";
                }
            }

            return "Хранилище не инициализировано";
        }

    }
}
