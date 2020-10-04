using System;
using System.Collections.Generic;
using System.Text;
using SOLID_Principles.OCP.Good.Abstract;

namespace SOLID_Principles.OCP.Good.Concrete
{
   public class Latte:GoodCoffee
    {
        public override double GetTotalPrice(double amount)
        {
            return amount * 9.50;
        }
    }
}
