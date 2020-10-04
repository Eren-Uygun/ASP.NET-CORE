using System;
using System.Collections.Generic;
using System.Text;
using SOLID_Principles.DIP.Good.Abstract;

namespace SOLID_Principles.DIP.Good.Concrete
{
   public class Salad:IProduct
    {
        public string GetCookingInstructions()
        {
            return "Salata Tarifi";
        }
    }
}
