using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SMS
{
    public class Student
    {
        public int studentID;
        public string studentName;
        public DateTime studentDOB;

        public Student()
        {
            Console.WriteLine("Enter Student ID:");
            if (!int.TryParse(Console.ReadLine(), out this.studentID))
            {
                Console.WriteLine("Invalid ID");
                this.studentID = 0;
            }
            Console.WriteLine("Enter Student Name:");
            this.studentName = Console.ReadLine();

            Console.WriteLine("Enter Date of Birth:");
            if (!DateTime.TryParse(Console.ReadLine(), out this.studentDOB))
            {
                Console.WriteLine("Invalid date");
                this.studentDOB = DateTime.MinValue;
            }
        }
    public void AddStudentDetails()
       {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    string query = "insert into studentdata(studentID,studentName,studentBirthDate) values (@StudentID,@StudentName,@StudentBirthDate)";
                    using(SqlCommand command=new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", this.studentID);
                        command.Parameters.AddWithValue("@StudentName", this.studentName);
                        command.Parameters.AddWithValue("@StudentBirthDate", this.studentDOB);

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
        public Student(int studentID,string studentName,DateTime studentDOB)
        {
            this.studentID = studentID;
            this.studentName = studentName;
            this.studentDOB = studentDOB;
        }
    }
}
