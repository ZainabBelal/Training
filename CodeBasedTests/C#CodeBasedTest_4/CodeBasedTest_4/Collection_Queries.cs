using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBasedTest_4
{
    class EmployeeDetails
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string DateOfBirth { get; set; }
        public string DateOfJoining { get; set; }
        public string City { get; set; }

    }
    class Collection_Queries
    {
        static void Main()
        {
            List<EmployeeDetails> empdetails = new List<EmployeeDetails>
            {
                new EmployeeDetails{EmployeeID=1001,FirstName="Malcolm",LastName="Daruwalla",Title="Manager",DateOfBirth="16/11/1984", DateOfJoining="08/06/2011",City="Mumbai"},
                new EmployeeDetails{EmployeeID=1002,FirstName="Asdin",LastName="Dhalla",Title="Asst Manager",DateOfBirth="20/08/1984 ", DateOfJoining="7/7/2012",City="Mumbai"},
                new EmployeeDetails{EmployeeID=1003,FirstName="Madhavi",LastName="Oza",Title="Consultant",DateOfBirth="14/11/1987", DateOfJoining="12/4/2015 ",City="Pune"},
                new EmployeeDetails{EmployeeID=1004,FirstName="Saba",LastName="Shaikh",Title="SE",DateOfBirth="3/6/1990", DateOfJoining="2/2/2016",City="Pune"},
                new EmployeeDetails{EmployeeID=1005,FirstName="Nazia",LastName="Shaikh",Title="SE",DateOfBirth="8/3/1991", DateOfJoining="2/2/2016",City="Mumbai"},
                new EmployeeDetails{EmployeeID=1006,FirstName="Amit",LastName="Pathak",Title="Consultant",DateOfBirth="7/11/1989", DateOfJoining="8/8/2014 ",City="Chennai"},
                new EmployeeDetails{EmployeeID=1007,FirstName="Vijay",LastName="Natrajan",Title="Consultant",DateOfBirth="2/12/1989", DateOfJoining="1/6/2015 ",City="Mumbai"},
                new EmployeeDetails{EmployeeID=1008,FirstName="Rahul",LastName="Dubey",Title="Associate",DateOfBirth="11/11/1993", DateOfJoining="6/11/2014",City="Chennai"},
                new EmployeeDetails{EmployeeID=1009,FirstName="Suresh",LastName="Mistry",Title="Associate",DateOfBirth="12/8/1992", DateOfJoining="	3/12/2014",City="Chennai"},
                new EmployeeDetails{EmployeeID=1010,FirstName="Sumit",LastName="Shah",Title="Manager",DateOfBirth="12/4/1991", DateOfJoining="2/1/2016",City="Pune"},
            };

            Console.WriteLine("-------Displaying details of all the employees---------");
            var emp1 = empdetails.Select(z => new { z.EmployeeID,z.FirstName, z.LastName, z.Title,z.DateOfBirth,z.DateOfJoining, z.City });
            foreach (var employee in emp1)
            {
                Console.WriteLine("EmpID:{0}\nName: {1} {2}\nTitle: {3}\nDOB:{4}\nDOJ:{5}\nCity:{6}\n",employee.EmployeeID, employee.FirstName,employee.LastName,employee.Title,employee.DateOfBirth,employee.DateOfJoining,employee.City);
            }

            Console.WriteLine("-------Displaying details of all the employees whose location is not Mumbai---------");
            var emp2= empdetails.Where(z => z.City != "Mumbai");
            foreach (var employee in emp2)
            {
                Console.WriteLine($"EmpID:{employee.EmployeeID}\nName:{employee.FirstName} {employee.LastName}\nTitle: {employee.Title}\nDOB:{employee.DateOfBirth}\nDOJ:{employee.DateOfJoining}\nCity: {employee.City}\n");
            }

            Console.WriteLine("---------Displaying details of all the employees whose title is Asst Manager--------");
            var emp3 = empdetails.Where(z => z.Title == "Asst Manager");
            foreach (var employee in emp3)
            {
                Console.WriteLine($"EmpID:{employee.EmployeeID}\nName:{employee.FirstName} {employee.LastName}\nTitle: {employee.Title}\nDOB:{employee.DateOfBirth}\nDOJ:{employee.DateOfJoining}\nCity: {employee.City}\n");
            }

            Console.WriteLine("---------Displaying details of all the employees whose Last Name starts with 'S'----------");
            var emp4 = empdetails.Where(z=>z.LastName.StartsWith("S"));
            foreach (var employee in emp4)
            {
                Console.WriteLine($"EmpID:{employee.EmployeeID}\nName:{employee.FirstName} {employee.LastName}\nTitle: {employee.Title} \nDOB: {employee.DateOfBirth} \nDOJ: {employee.DateOfJoining} \nCity:  {employee.City} \n");
            }
            Console.ReadLine();
        }
    }

}
    

