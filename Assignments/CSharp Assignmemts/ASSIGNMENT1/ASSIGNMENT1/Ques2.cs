using System;

//Program to check whether entered number is positive or negative
namespace ASSIGNMENT1
{
    class Ques2
    {
        public static void main()
        {
            int num;
            Console.WriteLine("Enter two Numbers:");
            num = Convert.ToInt32(Console.ReadLine());
            if(num>=0)
                Console.WriteLine("Entered Number is Positive");
            else
                Console.WriteLine("Entered Number is Negative");
            Console.ReadLine();

        }
    }
}
