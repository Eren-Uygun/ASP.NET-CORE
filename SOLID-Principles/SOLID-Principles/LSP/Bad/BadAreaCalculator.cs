using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.LSP.Bad
{
    public class BadAreaCalculator
    {
        public static double CalculateArea(BadRectangle rectangle)
        {
            return rectangle.Height * rectangle.Width;
        }
        public static double CalculateArea(BadSquare square)
        {
            return square.Height * square.Width;
        }
    }
}
