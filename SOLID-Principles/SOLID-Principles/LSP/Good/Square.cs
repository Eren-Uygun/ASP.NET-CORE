using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.LSP.Good
{
    public class Square:Shape
    {
        public int Width { get; set; }

        public double SquareArea()
        {
            return Width * Width;
        }

        
    }
}
