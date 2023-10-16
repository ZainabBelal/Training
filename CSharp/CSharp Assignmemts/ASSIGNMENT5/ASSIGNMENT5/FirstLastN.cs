using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT5
{
    class FirstLastN
    {
        public static void Display(string FN, string LN)
        {
            string UFN, ULN;
            UFN = FN.ToUpper();
            ULN = LN.ToUpper();
            Console.WriteLine("The name in upper case:\n" + UFN + "\n" + ULN);

        }
        public static void Main()
        {
            Console.WriteLine("Enter First name:");
            string FName = Console.ReadLine();
            Console.WriteLine("Enter Last name:");
            string LName = Console.ReadLine();
            FirstLastN.Display(FName, LName);
            Console.Read();
        }
    }
}
