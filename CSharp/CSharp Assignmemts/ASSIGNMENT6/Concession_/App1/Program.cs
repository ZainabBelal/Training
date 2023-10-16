using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Console.Write("Enter your name: ");
            string Name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int Age = Convert.ToInt32(Console.ReadLine());
            var conces = new Concession_.Class1
            {
                name = Name,
                age = Age
            };
           
            Console.WriteLine("Ticket Booking Details:");
            conces.CalculateConcession();

            Console.ReadLine();
            
        }
    }
}
