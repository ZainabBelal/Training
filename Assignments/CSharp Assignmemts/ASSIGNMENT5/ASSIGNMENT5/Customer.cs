using System;

class Customer
{
    public int CustId;
    public string Nm;
    public int Ag;
    public string Phn;
    public string Ct;
    public Customer()
    {
        CustId = 0;
        Nm = "";
        Ag = 0;
        Phn = "";
        Ct = "";
    }
    public Customer(int customerId, string name, int age, string phone, string city)
    {
        CustId = customerId;
        Nm = name;
        Ag = age;
        Phn = phone;
        Ct = city;
    }
    public void DisplayCustomer()
    {
        Console.WriteLine("Customer ID: " + CustId);
        Console.WriteLine("Name: " + Nm);
        Console.WriteLine("Age: " + Ag);
        Console.WriteLine("Phone: " + Phn);
        Console.WriteLine("City: " + Ct);
    }
    ~Customer()
    {
        Console.WriteLine("-----------Destructor Invoked-------------");
    }
    public static void DisplayCustomer1(Customer cus)
    {
        
            Console.WriteLine("Displaying customer information without object creation:");
            Console.WriteLine("Customer ID: " + cus.CustId);
            Console.WriteLine("Name: " + cus.Nm);
            Console.WriteLine("Age: " + cus.Ag);
            Console.WriteLine("Phone: " + cus.Phn);
            Console.WriteLine("City: " + cus.Ct);
       
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Customer Id:");
        int CI = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Name:");
        string nm = Console.ReadLine();
        Console.WriteLine("Enter Age:");
        int ag = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Phone number:");
        string ph = Console.ReadLine();
        Console.WriteLine("Enter City:");
        string c = Console.ReadLine();
       

        Customer customer1 = new Customer(CI,nm,ag,ph,c);
        Customer.DisplayCustomer1(customer1);
        Console.ReadLine();
    }
}
