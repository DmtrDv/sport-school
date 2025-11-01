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
            return result;
        }
    }
}
