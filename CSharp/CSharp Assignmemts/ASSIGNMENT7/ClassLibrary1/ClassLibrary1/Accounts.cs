using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Accounts
    {
        public Accounts(string str)
        {

        }
    }
    public class Employee
    {
        //public int ID { get; set; }
        //public 
        public string Login(string UID,string pswd)
        {
            if (string.IsNullOrEmpty(UID) || string.IsNullOrEmpty(pswd))
            {
                return "UserID or Password cannot be empty";
            }
            else if(UID == "Admin" && pswd == "123")
            {
                return "WELCOME ADMIN";
            }
            else
            {
                return "Incorrect UserId or password";
            }
        }
    }
}
