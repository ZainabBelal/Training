using System;
//Program to check whether numbers are equal or not

namespace ASSIGNMENT1
{
    class Ques1
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter two Numbers:");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            if(num1==num2)
                Console.WriteLine("Numbers are Equal");
            else
                Console.WriteLine("Numbers are not Equal");
            Console.ReadLine();
        }
    }
}
