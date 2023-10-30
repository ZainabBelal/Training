using System;

//program to accept a string from user and print its reverse
namespace ASSIGNMENT3
{
    class task2
    {
        static void Main()
        {
            Console.WriteLine("Enter a String:");
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            string rev = " ";
            for(int i = arr.Length - 1; i > -1; i--)
            {
                rev += arr[i];
            }
            Console.WriteLine("Reversed String :"+rev);
            Console.Read();

        }
    }
}
