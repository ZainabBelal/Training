using System;
namespace ASSIGNMENT4
{
    class student
    {
        public int rollno;
        public string nm;
        public string clas;
        public int sem_;
        public string branch_;
        public int[] marks = new int[5];
        public student(int roll_no,string name,string cls,int sem,string branch)
        {
            this.rollno = roll_no;
            this.nm = name;
            this.clas = cls;
            this.sem_ = sem;
            this.branch_ = branch;
            //Console.WriteLine("Hello");
        }
        public void GetMarks()
        {
            Console.WriteLine("Enter Marks in 5 Subjects:");
            for(int i = 0; i < 5; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Marks in 5 subjects are:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(marks[i]);
            }

        }
        public void displayresult()
        {
            float sum = 0; float avg=0;
            for (int i = 0; i < 5; i++)
            {
                sum = sum + marks[i];
            }
            avg = sum / 5;
            Console.WriteLine("Average of marks is:"+avg);
            bool temp=false;
            for (int i = 0; i < 5; i++)
            {
                if (marks[i] < 35) {  temp = false; }
                else if (marks[i] >= 35 && avg < 50) { temp = false; }
                else if (avg > 50) { temp = true; }
            }
            if(temp)
            {
                Console.WriteLine("Result:'PASSED'");
            }
            else
            {
                Console.WriteLine("Result:'FAILED'");
            }

               
        }
        public void DisplayData()
        {
            Console.WriteLine("Enter student's name:");
            nm = Console.ReadLine();
            Console.WriteLine("Enter student's Roll No.: ");
            rollno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student's Class:");
            clas = Console.ReadLine();
            Console.WriteLine("Enter Student's Semester:");
            sem_ = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student's Branch:");
            branch_ = Console.ReadLine();
            Console.WriteLine("Student's Name:"+nm);
            Console.WriteLine("Student's Roll No.:"+rollno);
            Console.WriteLine("Student's Class:"+clas);
            Console.WriteLine("Student's Semester:"+sem_);
            Console.WriteLine("Student's Branch:"+branch_);
            
        }
        public static void Main()
        {
            student s1 = new student(6,"Zainab","6",8,"hii");
            s1.DisplayData();
            s1.GetMarks();
            s1.displayresult();
            Console.Read();
        }
    }
}
