using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SMS
{
    class Enrollment
    {
        private string connectionstring;
        public Enrollment(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }
        public List<Enroll> GetAllEnrollments()
        {
            List<Enroll> enrolls = new List<Enroll>();
            using(SqlConnection connection=new SqlConnection(connectionstring))
            {
                connection.Open();
                string query = "select e.StudentID,s.StudentName as studentname,e.CourseID from Enrollments E" +
                    "join studentdata s on e.StudentID=s.StudentID";
                using(SqlCommand command=new SqlCommand(query, connection))
                {
                    SqlDataReader sdr = command.ExecuteReader();
                    while (sdr.Read())
                    {
                        int StudentID = sdr.GetInt32(0);
                        string StudentName = sdr.GetString(1);
                        int CourseID = sdr.GetInt32(2);
                    }
                    sdr.Close();
                }
            }
            return enrolls;
        }
    }
}
