using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SMS
{
    class Course
    {
        private int courseID;
        private string courseName;

        public Course()
        {
            Console.WriteLine("Enter Course ID:");
            if (!int.TryParse(Console.ReadLine(), out this.courseID))
            {
                Console.WriteLine("Invaid input");
                this.courseID = 0;
            }
            Console.WriteLine("Enter Course Name:");
            this.courseName = Console.ReadLine();
        }
        public int CourseID
        {
            get { return courseID; }
            set { courseID = value; }
        }
        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public void AddCourse()
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    string query = "insert into courses (CourseID,CourseName) values (@CourseID,@CourseName)";
                    using(SqlCommand command=new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CourseID", this.CourseID);
                        command.Parameters.AddWithValue("@CourseName", this.CourseName);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=ICS-LT-4KBDR73;Initial Catalog=StudentManagement;" +
                 "Integrated Security=True");
        }


        
    }
}
