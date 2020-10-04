using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.ISP.Bad
{
   public class Penguin:IBird
    {
        public string Fly()
        {
            throw new NotImplementedException();
        }

        public string Walk()
        {
            throw new NotImplementedException();
        }
    }
}
