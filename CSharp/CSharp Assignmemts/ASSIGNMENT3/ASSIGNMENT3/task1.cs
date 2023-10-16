using System;

//program to accept a string from user and diplay its length
namespace ASSIGNMENT3
{
    class task1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to check its length: ");
            task1 t = new task1();
            t.length_str();
            Console.Read();
        }
        public void length_str()
        {
            string str = Console.ReadLine();
            int len = str.Length;
            Console.WriteLine("Length of '{0}' is {1}",str,len);

        }
    }
}
