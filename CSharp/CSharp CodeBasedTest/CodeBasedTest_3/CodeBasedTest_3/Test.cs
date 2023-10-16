using System;


namespace CodeBasedTest_3
{
    class Box
    {
        public double Len;
        public double Brd;
        public Box(double Length,double Breadth)
        {
           Len=Length;
           Brd=Breadth;
        }
        public Box AddBox(Box b1)
        { 
            double length_new = this.Len + b1.Len;
            double breadth_new = this.Brd + b1.Brd;

            return new Box(length_new, breadth_new);
        }
        public void DisplayRes()
        {
            Console.WriteLine("Length:{0}",Len);
            Console.WriteLine("Breadth:{0}",Brd);
        }
    }
    class Test
    {
        static void Main()
        {
            Console.WriteLine("Details for first Box");
            Console.WriteLine("Enter length:");
            double Length_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter breadth:");
            double Breadth_1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Details for second Box");
            Console.WriteLine("Enter Length:");
            double Length_2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Breadth:");
            double Breadth_2 = Convert.ToDouble(Console.ReadLine());

            Box box1 = new Box(Length_1, Breadth_1);
            Box box2 = new Box(Length_2, Breadth_2);

            Box sumres = box1.AddBox(box2);
            Console.WriteLine("Third Box result:");
            sumres.DisplayRes();
            Console.ReadLine();
                
        }
    }
}
