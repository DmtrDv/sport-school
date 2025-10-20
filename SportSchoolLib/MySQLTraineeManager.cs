using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSchoolLib
{
    public class MySQLTraineeManager: ITraineeModel
    {
        public List<Trainee> GetListTrainee()
        {
            List<Trainee> trainees = new List<Trainee>();
            string connectionString =  "server=127.0.0.1;uid=root;pwd=vertrigo;database=sport_school;";

            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                string sql = "SELECT Id_Trainee, FIO, Birthday, Section, Category, FIOParent, PhoneNumberParent FROM trainee";
                MySqlCommand command = new MySqlCommand(sql, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int Id_trainee = reader.GetInt32("Id_Trainee");

                        Trainee trainee = new Trainee(Id_trainee);
                        trainee.FIO = reader.GetString("FIO");
                        trainee.Birthday = reader.GetDateTime("Birthday");
                        string sectionString = reader.GetString("Section");
                        if (Enum.TryParse<SportSchoolLib.section>(sectionString, true, out var section))
                        {
                            trainee.Section = section;
                        }
                        string categoryString = reader.GetString("Category");
                        if (Enum.TryParse<SportSchoolLib.category>(categoryString, true, out var category))
                        {
                            trainee.Category = category;
                        }
                        trainee.FIOParent = reader.GetString("FIOParent");
                        trainee.PhoneNumberParent = reader.GetString("PhoneNumberParent");

                        trainees.Add(trainee);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return trainees;
        }
    }
}
