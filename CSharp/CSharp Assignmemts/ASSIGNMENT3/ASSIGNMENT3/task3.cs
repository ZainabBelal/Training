using System;

//program to accept two words from user and find if they are same or not
namespace ASSIGNMENT3
{
    //program to check if two entered strings are same or not
    class task3
    {
        public static void Main()
        {
            string word1="", word2="";
            Console.WriteLine("Enter first String:");
            word1 = Console.ReadLine();
            Console.WriteLine("Enter second String:");
            word2 = Console.ReadLine();

            // Console.WriteLine(word1.Equals(word2));
            if (word1.Equals(word2))
            {
                Console.WriteLine("Strings are Same");
            }
            else
                Console.WriteLine("Strings are Different");
            Console.Read();
        }
    }
}
