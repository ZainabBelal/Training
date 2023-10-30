using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    class Employees
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }

        static void Main()
        {
            List<Employees> EmployeeList = new List<Employees>
            {
                new Employees { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB =new DateTime(1984,11,16) , DOJ = new DateTime(2011, 8, 6), City = "Mumbai" },
                new Employees { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
                new Employees { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 12, 4), City = "Pune" },
                new Employees { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
                new Employees { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
                new Employees { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 7, 11), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
                new Employees { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 2, 12), DOJ = new DateTime(2015, 1, 6), City = "Mumbai" },
                new Employees { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 6, 11), City = "Chennai" },
                new Employees { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 12, 8), DOJ = new DateTime(2014, 3, 12), City = "Chennai" },
                new Employees { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 2, 1), City = "Pune" }
            };

            Console.WriteLine("Employees who joined before 1 / 1 / 2015:");
            var Q1 = EmployeeList.Where(empl => empl.DOJ < new DateTime(2015, 1, 1));
            foreach (var employee in Q1)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}, {employee.DOJ.ToShortDateString()}");
            }
            Console.WriteLine();

            var Q2 = EmployeeList.Where(empl => empl.DOB > new DateTime(1990, 1, 1));
            Console.WriteLine("Employees who are born after 1/1/1990:");
            foreach (var employee in Q2)
            {
                Console.WriteLine($"{employee.EmployeeID}--->{employee.FirstName} {employee.LastName}");
            }
            Console.WriteLine();

            var Q3=EmployeeList.Where(empl => empl.Title == "Consultant" || empl.Title == "Associate");
            Console.WriteLine("Consultants and Associates are:");
            foreach (var employee in Q3 )
            {
                Console.WriteLine($"{employee.EmployeeID}: {employee.FirstName} {employee.LastName}");
            }
            Console.WriteLine();

            Console.WriteLine($"Total number of Employees :  {EmployeeList.Count} ");
            Console.WriteLine();

            Console.WriteLine($"Total number of employees who belong to Chennai are: {EmployeeList.Count(empl => empl.City == "Chennai")}");
            Console.WriteLine();

            int Q6 = EmployeeList.Max(empl => empl.EmployeeID);
            Console.WriteLine($"Highest Employee ID: {Q6}");
            Console.WriteLine();

            Console.WriteLine($"Total number of employees who joined after 1/1/2015: {EmployeeList.Count(empl => empl.DOJ > new DateTime(2015, 1, 1))}");
            Console.WriteLine();

            Console.WriteLine($"Total number of employees whose title is not 'Associate': {EmployeeList.Count(empl => empl.Title != "Associate")}");
            Console.WriteLine();

            var Q10 = EmployeeList.GroupBy(empl => empl.City).Select(fir => new { City = fir.Key, Count = fir.Count() });
            Console.WriteLine("Total number of employees based on a particular City are:");
            foreach (var city in Q10)
            {
                Console.WriteLine($"{city.City}: {city.Count}");
            }
            Console.WriteLine();

            var Q11 = EmployeeList.OrderBy(empl => empl.DOB).Last();
            Console.WriteLine($"Youngest employee:{Q11.FirstName} {Q11.LastName}");
            Console.ReadLine();
            
            Console.Read();
        }    
    }
}

