using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSchoolLib
{
    public interface IStorageTrainee
    {
        void AddTrainee(Trainee trainee);
        bool Id_TraineeExists(int Id_Trainee);
    }
}
