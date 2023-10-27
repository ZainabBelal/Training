using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SMS
{
    class AppEngine
    {
        public static List<Student> GetStudents()
        {
            List<Student> stud = new List<Student>();
            using (SqlConnection connection = GetConnection())
            {
                string query = "select * from studentdata";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader sdr = command.ExecuteReader();
                    Console.WriteLine("{0,-5} {1,-20} {2,-20}","ID","Name","DateofBirth");
                    Console.WriteLine("--------------------------------------------------");

                    while (sdr.Read())
                    {
                        int stid = sdr.GetInt32(0);
                        string stname = sdr.GetString(1);
                        DateTime stdob = sdr.GetDateTime(2);
                        Console.WriteLine("{0,-5} {1,-20} {2,-20}",stid,stname,stdob);

                    }
                    sdr.Close();
                }
            }
            return stud;
        }
        public static List<Course> GetCourses()
        {
            List<Course> course = new List<Course>();
            using(SqlConnection connection = GetConnection())
            {
                string query = "select * from courses";
                using(SqlCommand command=new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader sdr = command.ExecuteReader();
                    Console.WriteLine("{0} {1}","ID","Course Name");
                    Console.WriteLine("-----------------------------------");

                    while (sdr.Read())
                    {
                        int cid = sdr.GetInt32(0);
                        string cname = sdr.GetString(1);
                        Console.WriteLine("{0} {1}",cid,cname);
                    }
                    sdr.Close();
                }
            }
            return course;
        }
        public static void EnrollStudent(int studentID/*,string studentName*/,int courseID)
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    string query = "insert into Enrollments (StudentID,CourseID) values (@StudentID," +
                        "@CourseID)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@studentID", studentID);
                        //command.Parameters.AddWithValue("@studentName", studentName);
                        command.Parameters.AddWithValue("@courseID", courseID);

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
        public static List<Enroll> GetEnrollments()
        {
            
            

                List<Enroll> enrolls = new List<Enroll>();
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    string query = "select e.StudentID,s.StudentName as studentname, e.CourseID,c.CourseName from Enrollments E" +
                        "join studentdata s on e.StudentID=s.studentID " +
                        "join courses c on e.CourseID=c.CourseID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader sdr = command.ExecuteReader();
                        while (sdr.Read())
                        {
                            int sid = sdr.GetInt32(0);
                            string sname = sdr.GetString(1);
                            int cid = sdr.GetInt32(2);
                            string cname = sdr.GetString(3);

                            enrolls.Add(new Enroll(sid, sname, cid, cname));
                        }
                        sdr.Close();
                    }

                }
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }

            return enrolls; 
              
            

        }
        public static Student Retrievestudent(int studentID)
        {
            using(SqlConnection connection = GetConnection())
            {
                connection.Open();
                string query = "select * from studentdata where StudentID =@studentID";
                using(SqlCommand command=new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@studentID", studentID);
                    SqlDataReader sdr = command.ExecuteReader();
                    if (sdr.Read())
                    {
                        int id = sdr.GetInt32(0);
                        string name = sdr.GetString(1);
                        DateTime dateofbirth = sdr.GetDateTime(2);
                        return new Student { studentID = id, studentName = name, studentDOB = dateofbirth };
                    }
                    return null;
                }
            }
        }
        public static Course RetrieveCourse(int CourseID)
        {
            using(SqlConnection connection = GetConnection())
            {
                connection.Open();
                string query = "select * from courses where CourseID=@CourseID";
                using(SqlCommand command=new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CourseID", CourseID);
                    SqlDataReader sdr = command.ExecuteReader();
                    if (sdr.Read())
                    {
                        int courseId = sdr.GetInt32(0);
                        string courseName = sdr.GetString(1);
                        return new Course { CourseID = courseId, CourseName = courseName };
                    }
                }return null;
            }
        }

        

        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=ICS-LT-4KBDR73;Initial Catalog=StudentManagement;" +
                "Integrated Security=True");

        }
    }
}
