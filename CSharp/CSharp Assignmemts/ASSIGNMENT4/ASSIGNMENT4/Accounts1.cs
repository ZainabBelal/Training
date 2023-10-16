using System;

namespace ASSIGNMENT4
{
    class Accounts1
    {
        public string ac_n; public string custname; public string acc_ty;
        Accounts1(string acc_no, string cust_nm, string acc_type)
        {
            ac_n=acc_no;
           custname = cust_nm; 
           acc_ty= acc_type;
           
        }
        public static void Main()
        {
            string ac_n; string custname; string acc_ty;
         int amt, choice;
            Console.WriteLine("Enter the acc no:");
            ac_n = Console.ReadLine();
            Console.WriteLine("Enter Customer Name:");
            custname = Console.ReadLine();
            Console.WriteLine("Enter Acc type (Savings/Current):");
            acc_ty = Console.ReadLine();


            Console.WriteLine("ENTER 1 FOR DEPOSIT\nENTER 2 FOR WITHDRAWAL\n");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Enter the amount that you want to deposit:");
                amt = Convert.ToInt32(Console.ReadLine());
               
                Console.WriteLine("The Updated bank balance is: " + credit(amt));
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter the amount that you want to withdraw:");
                amt = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("The Updated bank balance is: " + debit(amt));
            }
            Accounts1 a1 = new Accounts1(ac_n,custname,acc_ty);   
            a1.showData();
            Console.Read();
            
        }
        public void showData()
        {
            

            Console.WriteLine("The Account number is: " + ac_n);
            Console.WriteLine("The Account Holder's name is: " + custname);
            Console.WriteLine("The Account Type is: " + acc_ty);
        }

        public static float credit(int amt)
        {
            float existing_balance;
            Console.WriteLine("Enter the existing balance in your account:");
            existing_balance = Convert.ToSingle(Console.ReadLine());
            float updated_balance = amt + existing_balance;
            return updated_balance;
        }
        public static float debit(int amt)
        {
            float existin_balance;
            Console.WriteLine("Enter the existing balace in your account:");
            existin_balance = Convert.ToSingle(Console.ReadLine());
            float update_balance = existin_balance-amt;
            return update_balance;
        }
       
    }
}
