using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession_
{
    public class Class1
    {
        public int totalfare = 500;
        public string name { get; set; }
        public int age { get; set; }
        public void CalculateConcession()
        {
            if (age <= 5)
            {
                Console.WriteLine("'Little Champs-Free Ticket'\nName:{0}\nAge:{1}", name, age);
            }
            else if (age >= 60)
            {
                double concess_amt = totalfare * 0.30;
                double calculated_amt = totalfare - concess_amt;
                Console.WriteLine("'Senior Citizen-Discounted Tickets'\nName:{0}\nAge{1}\nCalculted Fare:{2}", name, age, calculated_amt);
            }
            else
            {
                Console.WriteLine("'Ticket Booked'\nName:{0}\nAge{1}\nFare:{2}", name, age, totalfare);
            }
        }
    }   
}
