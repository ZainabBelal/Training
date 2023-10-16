using System;

namespace ASSIGNMENT5
{
   class Saledetails
    {
        public int SNo;
        public int PNo;
        public double Price;
        public DateTime Datesale;
        public int Qty;
        public double Totalamt;

      
        public Saledetails(int saleno, int productno, double price, int quantity, DateTime date)
        {
            this.SNo = saleno;
            this.PNo = productno;
            this.Price = price;
            this.Qty = quantity;
            this.Datesale = date;
            this.Totalamt = 0.0;
        }

        
        public void Sales()
        {
            this.Totalamt = this. Qty * this.Price;
        }

        
        public void ShowData()
        {
            Console.WriteLine("Sales No: " + this.SNo);
            Console.WriteLine("Product No: " + this.PNo);
            Console.WriteLine("Price: " + this.Price);
            Console.WriteLine("Quantity: " + this.Qty);
            Console.WriteLine("Date of Sale: " + this.Datesale.ToString("dd/MM/yyyy"));
            Console.WriteLine("Total Amount: " + this.Totalamt);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Sales Number:");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter product number:");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter price:");
            double p1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Quantity:");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Date of Sale:");
            DateTime dt =Convert.ToDateTime( Console.ReadLine());

            Saledetails sale1 = new Saledetails(s,p,p1,q,dt);
            sale1.Sales();
            sale1.ShowData();
            Console.Read();
        }
    }

}
