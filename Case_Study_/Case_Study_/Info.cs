using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_
{
    public class Info
    {
        public static void DisplayStudentDetails(Student student)
        {
            Console.WriteLine($"Student ID: {student.Id}");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Date of Birth: {student.DateOfBirth}");
        }

        public static void DisplayEnrollmentDetails(Enroll enrollment)
        {
            Console.WriteLine($"Student: {enrollment.Student.Name}");
            Console.WriteLine($"Course: {enrollment.Course.CourseName}");
            Console.WriteLine($"Enrollment Date: {enrollment.EnrollmentDate}");
        }
    }
}
