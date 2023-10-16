using System;

namespace ASSIGNMENT8
{
    public interface IShapes
    {
        double Calculate_Area();
        double Calculate_Perimeter();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose one shape (from Triangle, Square and Rectangle):");
            string input = Console.ReadLine().ToLower();

            IShapes shape=null;

            switch (input)
            {
                case "triangle":
                    Console.Write("Enter the base length: ");
                    double baseLength = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the height: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    shape = new Triangle(baseLength, height);
                    break;

                case "square":
                    Console.Write("Enter the side length: ");
                    double sideLength = Convert.ToDouble(Console.ReadLine());
                    shape = new Square(sideLength);
                    break;

                case "rectangle":
                    Console.Write("Enter the length: ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the width: ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    shape = new Rectangle(length, width);
                    break;

                default:
                    Console.WriteLine("Invalid input. Please choose a valid shape.");
                    break;
            }

            double finalarea = shape.Calculate_Area();
            double finalperimeter = shape.Calculate_Perimeter();

            Console.WriteLine("Area is => {0}", finalarea);
            Console.WriteLine("Perimeter is => {0}", finalperimeter);

            Console.ReadLine();
        }
    }
}
