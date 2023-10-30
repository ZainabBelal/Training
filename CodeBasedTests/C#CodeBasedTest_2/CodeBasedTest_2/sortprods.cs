using System;

/*Create a Class called Products with Productid, Product Name, Price. 
 * Accept 10 Products, sort them based on the price, and display the sorted Products*/
namespace CodeBasedTest_2

{
    class sortprods
    {
        int[] ProdID = new int[10];
        string[] ProdName = new string[10];
        double[] ProdPrice = new double[10];
        public void Accept()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"Enter details for Product {i}:");

                Console.Write("Product ID: ");
                ProdID[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Product Name: ");
                ProdName[i] = Console.ReadLine();

                Console.Write("Price: ");
                ProdPrice[i] = double.Parse(Console.ReadLine());

            }
        }
        public void sort()
        {
            Array.Sort(ProdPrice);
        }
        public void display()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write(" " + ProdID[i]);
                Console.Write(" " + ProdName[i]);
                Console.WriteLine(" " + ProdPrice[i]);
            }
        }
        static void Main(string[] args)
        {
            sortprods sp = new sortprods();
            sp.Accept();
            sp.sort();
            sp.display();
            Console.ReadLine();

        }
    }
}
