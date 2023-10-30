using System;


namespace ASSIGNMENT1
{
    class Ques3
    {
        public static void Main()
        {
            int num1, num2, opr, res;
            Console.WriteLine("Enter First Number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            num2 = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine(" Enter 1 for Addition \n Enter 2 for Subtraction \n Enter 3 for Multiplication \n Enter 4 for Division\n");
            opr =Convert.ToInt32( Console.ReadLine());
            switch (opr)
            {
                case 1:
                    int sum = num1 + num2;
                    Console.WriteLine("Sum is "+sum);
                    break;
                case 2:
                    int diff = num1 - num2;
                    Console.WriteLine("Difference is "+diff);
                    break;
                case 3:
                    int prod = num1 * num2;
                    Console.WriteLine("Product is "+prod);
                    break;
                case 4:
                    int div = num1 / num2;
                    Console.WriteLine("Division is "+div);
                    break;
                default:
                    Console.WriteLine("Invalid Input!!");
                    break;

            }
            Console.ReadLine();
        }
    }
}
