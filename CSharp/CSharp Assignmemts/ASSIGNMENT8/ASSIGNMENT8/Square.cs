using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT8
{
    public class Square : IShapes
    {
        public double Side_Length { get; set; }

        public Square(double sidelength)
        {
            Side_Length=sidelength;
        }

        public double Calculate_Area()
        {
            return Side_Length*Side_Length;
        }

        public double Calculate_Perimeter()
        {
            return 4*Side_Length;
        }
    }
}