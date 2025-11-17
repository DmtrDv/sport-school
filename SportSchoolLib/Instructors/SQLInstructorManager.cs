using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSchoolLib
{
    public class SQLInstructorManager: IInstructorManager
    {
        MySqlConnection conn;

        public List<Instructor> GetInstructors()
        {
            List<Instructor> result = new List<Instructor>();

            try
            {
                conn = new MySqlConnection(AppSettings.ConnectionString);
                conn.Open();
                const string query = "SELECT Id_instructor, FIOInstructor, qualification, NumberPhoneInstructor, Section FROM instructor";
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
        public string AddInstructor(Instructor instructor)
        {
            using (MySqlConnection conn = new MySqlConnection(AppSettings.ConnectionString))
            {
                try
                {                
                    conn.Open();
                    string request = @"INSERT INTO instructor 
                                (FIOInstructor, qualification, NumberPhoneInstructor, Section) 
                                VALUES (@FIOInstructor, @qualification, @NumberPhoneInstructor, @Section)";

                    using (MySqlCommand command = new MySqlCommand(request, conn))
                    {
                        command.Parameters.AddWithValue("@FIOInstructor", instructor.FIO_Instructor);
                        command.Parameters.AddWithValue("@qualification", instructor.Qualification.ToString());
                        command.Parameters.AddWithValue("@NumberPhoneInstructor", instructor.PhoneNumberInstructor);
                        command.Parameters.AddWithValue("@Section", instructor.Section.ToString());

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return "Новый тренер успешно добавлен";
                        }
                        else
                        {
                            return "Ошибка: тренер не был добавлен";
                        }
                    }
                }
                catch (Exception ex)
                {
                    return "Ошибка при добавлении: " + ex;
                }
            }

        }
    }
}
