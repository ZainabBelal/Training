using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    class Enroll
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public Enroll(int StudentID,string StudentName,int CourseID,string CourseName)
        {
            this.StudentID = StudentID;
            this.StudentName = StudentName;
            this.CourseID = CourseID;
            this.CourseName = CourseName;
        }
    }
}
