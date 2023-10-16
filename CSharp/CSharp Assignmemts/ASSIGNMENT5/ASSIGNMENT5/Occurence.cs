using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT5
{
    class Occurence
    {
        public static int Count(string nm, char c)
        {
            int count = 0;
            for(int i = 0; i < nm.Length; i++)
            {
                if (nm[i] == c)
                    count++;
            }
            return count;
        }
        public static void Main()
        {
            Console.WriteLine("Enter a string:");
            string s = Console.ReadLine();
            Console.WriteLine("Enter the character you want to count occurence of:");
            char ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("'"+ch+"'"+" occurs "+Count(s,ch)+" times in "+"'"+s+"'");
            Console.ReadLine();
        }
    }   
}
