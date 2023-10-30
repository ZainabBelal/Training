using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBasedTest
{
    class StrinReplace1
    {
        
           
            public static void Main()
            {
                Console.WriteLine("Enter a String:");
                string str = Console.ReadLine();
                Console.WriteLine("Enter the position of Character you want to remove:");
                int pos = Convert.ToInt32(Console.ReadLine());
                string str2 = str.Remove(pos, 1);

                Console.WriteLine(str2);
                Console.ReadLine();
            }
        }
    }


