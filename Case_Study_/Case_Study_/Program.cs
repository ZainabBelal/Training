using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_
{
    class Program
    {
        

        static void Main(string[] args)
        {
            

            var appEngine = new appEngine();
            var info = new Info();
            var UserInterface = new UserInterface(appEngine, info);

          
            appEngine.Introduce(new Course(1001, "B.Tech in CSE"));
            appEngine.Introduce(new Course(1002, "B.Tech in CE"));
            appEngine.Introduce(new Course(1003, "B.Tech in ME"));
            appEngine.Introduce(new Course(2001, "BCA"));
            appEngine.Introduce(new Course(2002, "MCA"));
            appEngine.Introduce(new Course(3001, "BBA"));
            appEngine.Introduce(new Course(3002, "MBA"));
            appEngine.Register(new Student(101, "Abhinav Tiwari", new DateTime(2000, 1, 15)));
            appEngine.Register(new Student(102, "Shivani Singh", new DateTime(1999, 5, 20)));
            appEngine.Register(new Student(102, "Sharad Gupta", new DateTime(2001, 5, 21)));
            appEngine.Register(new Student(102, "Akanksha Yadav", new DateTime(2001, 6, 30)));




            appEngine.Enroll(appEngine.ListOfStudents()[0], appEngine.ListOfCourses()[0]);
            appEngine.Enroll(appEngine.ListOfStudents()[1], appEngine.ListOfCourses()[1]);
            appEngine.Enroll(appEngine.ListOfStudents()[2], appEngine.ListOfCourses()[2]);
            appEngine.Enroll(appEngine.ListOfStudents()[3], appEngine.ListOfCourses()[3]);





            //info.DisplayStudentDetails(appEngine.ListOfStudents()[0]);
            //info.DisplayEnrollmentDetails(appEngine.ListOfEnrollments()[0]);


            UserInterface.showFirstScreen();

            Console.ReadLine();
        }
        //public void Scenario1(Info info)
        //{
            

            
        //    Student student1 = new Student(101, "John Doe", new DateTime(2000, 1, 15));
        //    Student student2 = new Student(102, "Jane Smith", new DateTime(1999, 5, 20));

            
        //    info.DisplayStudentDetails(student1);
        //    info.DisplayStudentDetails(student2);
        //}
        //public void Scenario2(  Info info)
        //{
        //    Student[] students = new Student[3];

            
        //    students[0] = new Student(201, "", new DateTime(2001, 8, 10));
        //    students[1] = new Student(202, "", new DateTime(2002, 3, 25));
        //    students[2] = new Student(203, "", new DateTime(2003, 11, 5));

        //    foreach (var student in students)
        //    {
        //        info.DisplayStudentDetails(student);
        //    }
        }
    }

    

