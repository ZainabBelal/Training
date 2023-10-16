using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBasedTest
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number in order to print a multiplication table:");
            int num = Convert.ToInt32(Console.ReadLine()); int prod = 1;
            for (int i = 0; i <= 10; i++)
            {
                prod = num * i;
                Console.WriteLine(num + " * " + i + " = " + prod);
            }
            Console.Read();
        }
    }
}
