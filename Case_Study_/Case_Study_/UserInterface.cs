using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_
{
   class UserInterface
    {
        public UserInterface(appEngine appEngine, Info info)
        {
            this.appEngine = appEngine;
            this.info = info;
        }
        public void showFirstScreen()
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Welcome to SMS (Student Management System) v1.0");
            Console.WriteLine("Tell us who you are:\n1. Student\n2. Admin\n3.Enroll New Student\n4.Exit");
            Console.Write("Enter your choice (1 or 2 or 3 or 4): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    StudentScreen();
                    break;
                case 2:
                    AdminScreen();
                    break;
                case 3:
                    EnrollNewStudent();
                    break;
                case 4:
                    Console.WriteLine("Thankyou for visiting SMS!!!!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter from (1/2/3/4)");
                    break;
            }
        }

        public void StudentScreen()
        {
            
            Console.WriteLine("Student Screen");
            Console.WriteLine("1. View Student Enrollments");
            Console.WriteLine("2. View Available Courses");
            Console.WriteLine("3. Back to Main Menu");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ShowStudentEnrollments();
                    break;
                case 2:
                    ShowAvailableCourses();
                    break;
                case 3:
                    showFirstScreen(); 
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    StudentScreen();
                    break;
            }

        }

        public void AdminScreen()
        {
          
            Console.WriteLine("Admin Screen");
            Console.WriteLine("1. View All Students");
            Console.WriteLine("2. View All Courses");
            Console.WriteLine("3. Add a New Course");
            Console.WriteLine("4. Back to Main Menu");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ViewAllStudents();
                    break;
                case 2:
                    ViewAllCourses();
                    break;
                case 3:
                    CreateNewCourse();
                    break;
                case 4:
                    showFirstScreen();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    AdminScreen();
                    break;
            }

        }
        public void EnrollNewStudent()
        {
            Console.WriteLine("Enroll a New Student:");
            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine();
            Console.Write("Enter student date of birth (yyyy-MM-dd): ");

            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
            
                Console.WriteLine("Available Courses:");
                Course[] courses = appEngine.ListOfCourses();

                for (int i = 0; i < courses.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {courses[i].CourseName}");
                }

                
                int courseChoice;
               
                
                    Console.Write("Enter the number of the course to enroll in from above courses: ");
                    courseChoice = int.Parse(Console.ReadLine());
               
                
                Course chosenCourse = courses[courseChoice - 1];
                Student Student1 = new Student(GetNextStudentId(), studentName, dateOfBirth);
                appEngine.Register(Student1);
                appEngine.Enroll(Student1, chosenCourse);

                Console.WriteLine($"Student enrolled successfully and Student ID generated is: {Student1.Id}");
            
            

            Console.WriteLine("Press any key to return to the Student Menu...");
            Console.ReadKey();
            StudentScreen();
        }

        private int GetNextStudentId()
        {
            
            return appEngine.ListOfStudents().Length + 1;
        }
    


        public void ShowStudentEnrollments()
        {
            Console.WriteLine("Your Enrollments:");
            Student[] students = appEngine.ListOfStudents();
            
            Student currentStudent = students[0];

        
            Enroll[] enrollments = appEngine.ListOfEnrollments();

            foreach (var enrollment in enrollments)
            {
                if (enrollment.Student == currentStudent)
                {
                    Info.DisplayEnrollmentDetails(enrollment);
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Press any key to return to the Student Menu...");
            Console.ReadKey();
            StudentScreen(); 
        }
        public void ShowAvailableCourses()
        {
            Console.WriteLine("Available Courses:");
            Course[] courses = appEngine.ListOfCourses();

            foreach (var course in courses)
            {

                Console.WriteLine($"{course.CourseId}. {course.CourseName}");
            }

            Console.WriteLine("Press any key to return to the Student Menu...");
            Console.ReadKey();
            StudentScreen();
        }

        public void ViewAllStudents()
        {
            Console.WriteLine("All Students:");
            Student[] students = appEngine.ListOfStudents();

            foreach (var student in students)
            {
                
                Info.DisplayStudentDetails(student);
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to return to the Admin Menu...");
            Console.ReadKey();
            AdminScreen(); 
        }
        public void ViewAllCourses()
        {
            Console.WriteLine("All Courses:");
            Course[] courses = appEngine.ListOfCourses();

            foreach (var course in courses)
            {
               
                Console.WriteLine($"{course.CourseId}. {course.CourseName}");
            }

            Console.WriteLine("Press any key to return to the Admin Menu...");
            Console.ReadKey();
            AdminScreen();
        }
        private static int nextCourseId = 1;
        private appEngine appEngine;
        private Info info;

        

        private static int GenerateNewCourseId()
        {
            return nextCourseId++;
        }
        public void CreateNewCourse()
        {
            Console.Write("Enter the course name: ");
            string courseName = Console.ReadLine();
            int courseId = GenerateNewCourseId();
            var newCourse = new Course(courseId, courseName);
            appEngine.Introduce(newCourse);
            Console.WriteLine($"New course created: {courseName}");

            Console.WriteLine("Press any key to return to the Admin Menu...");
            Console.ReadKey();
            AdminScreen();
        }


    }
}

    

