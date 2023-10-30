using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT8
{
    public class Triangle : IShapes
    {
            public double Base { get; set; }
            public double Height { get; set; }

            public Triangle(double baseLength, double height)
            {
                Base = baseLength;
                Height = height;
            }

            public double Calculate_Area()
            {
                return 0.5*Base*Height;
            }

            public double Calculate_Perimeter()
            {
                return 0;
            }
    }

}

