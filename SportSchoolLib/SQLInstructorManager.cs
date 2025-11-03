using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSchoolLib
{
    public class SQLInstructorManager
    {
        MySqlConnection conn;

        public List<Instructor> GetInstructors()
        {
            List<Instructor> result = new List<Instructor>();

            try
            {
                conn = new MySqlConnection(AppSettings.ConnectionString);
                conn.Open();
                const string query = "SELECT  FROM;";
                MySqlCommand command = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int ID = reader.GetInt32("Id_instructor");

                        Instructor instructor= new Instructor(ID);
                        instructor.FIO_Instructor = reader.GetString("FIOInstructor");
                        string qualificationString = reader.GetString("qualification");
                        if (Enum.TryParse<SportSchoolLib.qualification>(qualificationString, true, out var qualification))
                        {
                            instructor.Qualification = qualification;
                        }
                        instructor.PhoneNumberInstructor = reader.GetString("NumberPhoneInstructor");
                        string sectionString = reader.GetString("Section");
                        if (Enum.TryParse<SportSchoolLib.section>(sectionString, true, out var section))
                        {
                            instructor.Section = section;
                        }

                        result.Add(instructor);
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Ошибка при загрузке тренеров: " + ex.Message);
            }

            return result;
        }
    }
}
