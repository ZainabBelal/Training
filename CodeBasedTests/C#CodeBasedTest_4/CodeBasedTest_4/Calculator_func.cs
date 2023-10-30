using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBasedTest_4
{
    delegate int Calculator(int x, int y);
    class Calculator_func
    {
        public static int Addition(int x, int y)
        {
            return x + y;
        }
        public static int Subtraction(int x, int y)
        {
            return x - y;
        }
        public static int Multiplication(int x, int y)
        {
            return x * y;
        }
        static void Main()
        {
            
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Enter your choice:");
            int ch = Convert.ToInt32(Console.ReadLine());
            Calculator c1 = null;

            switch (ch)
            {
                case 1:
                    c1 = Addition;
                    break;
                case 2:
                    c1 = Subtraction;
                    break;
                case 3:
                    c1 = Multiplication;
                    break;
                default:
                    Console.WriteLine("Invalid Input, Try again!!");
                    break;
            }
            Console.WriteLine("Enter First number:");
            int fno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int sno = int.Parse(Console.ReadLine());
            int final_res = c1(fno, sno);
            Console.WriteLine("Result:"+final_res);
            Console.ReadLine();
        }
        
    }
}
