using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace AdoCodeBased
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=ICS-LT-4KBDR73;Initial Catalog=CodeBasedTest;" + "Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                
                using (SqlCommand cmd = new SqlCommand("insert_emp_records", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                   
               
                    Console.Write("Employee Name: ");
                    string empname = Console.ReadLine();
                  
                    Console.Write("Employee Salary: ");
                    if (!decimal.TryParse(Console.ReadLine(), out decimal empsal))
                    {
                        Console.WriteLine("Invalid salary input.");
                        return;
                    }
                    Console.WriteLine("Employment Type (F for full-time, P for part-time): ");
                    string emptype = Console.ReadLine();
                    if (emptype != "F" && emptype != "P")
                    {
                        Console.WriteLine("Invalid employment type input.");
                        return;
                    }
                    cmd.Parameters.Add(new SqlParameter("@empname", empname));
                    cmd.Parameters.Add(new SqlParameter("@empsal", empsal));
                    cmd.Parameters.Add(new SqlParameter("@emptype", emptype));
                    cmd.ExecuteNonQuery();
                }

                Console.WriteLine("Congratulations.....A new Employee has been added successfully!!!");
                Console.WriteLine("------------------------------------------------------------------");

                DisplayRecords(con);
                Console.ReadLine();
            }
        }
       
        static void DisplayRecords(SqlConnection con)
        {
            Console.WriteLine("The Employee Table is:");
            using (SqlCommand selectCommand = new SqlCommand("SELECT * FROM Code_Employee", con))
            using (SqlDataAdapter adapter = new SqlDataAdapter(selectCommand))
            {
                DataTable employeeTable = new DataTable();
                adapter.Fill(employeeTable);

                foreach (DataRow row in employeeTable.Rows)
                {
                    Console.WriteLine($"EmployeeID-->{row["empno"]}  |   Name-->{row["empname"]}     |  Salary-->{row["empsal"]}    |  Type-->{row["emptype"]}");
                }
            }
        }
    }
}