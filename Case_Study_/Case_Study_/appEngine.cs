using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_
{
    public class appEngine
    {
        public static List<Student> students = new List<Student>();
        public static List<Course> courses = new List<Course>();
        public static List<Enroll> enrollments = new List<Enroll>();

        public static void Introduce(Course course)
        {
            courses.Add(course);
            Console.WriteLine($"New course introduced: {course.CourseName}");
        }

        public static void Register(Student student)
        {
            students.Add(student);
            Console.WriteLine($"Student registered: {student.Name}");
        }

        public static Student[] ListOfStudents()
        {
            return students.ToArray();
        }

        public static Course[] ListOfCourses()
        {
            return courses.ToArray();
        }

        public void Enroll(Student student, Course course)
        {
            var enrollment = new Enroll(student, course,DateTime.Today);
            enrollments.Add(enrollment);
            Console.WriteLine($"{student.Name} enrolled successfully in {course.CourseName}");
        }

        public static Enroll[] ListOfEnrollments()
        {
            return enrollments.ToArray();
        }
    }
}
