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

        public TraineeDBManager()
        {
            trainees_ = new List<Trainee>();
        }
        public TraineeDBManager(IStorageTrainee storage)
        {
            storage_ = storage;
            trainees_ = new List<Trainee>();
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
            }
            return "Ученик успешно добавлен";
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
