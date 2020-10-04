using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.LSP.Good
{
   public class Rectangle:Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public double RectangleArea()
        {
            return Width * Height;
        }
    }
}
