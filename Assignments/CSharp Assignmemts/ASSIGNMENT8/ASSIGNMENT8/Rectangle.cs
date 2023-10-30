using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT8
{
    public class Rectangle : IShapes
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public double Calculate_Area()
        {
            return Length*Width;
        }
        public double Calculate_Perimeter()
        {
            return 2*(Length+Width);
        }
    }

}
