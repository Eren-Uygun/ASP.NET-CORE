using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.OCP.Bad
{

    public enum CoffeeType
    {
        Latte,
        Espresso,
        Macchiato,

    }
  public  class BadCoffee
    {
        public double GetTotalPrice(double amount, CoffeeType coffeeType)
        {
            double totalprice = 0;

            if (coffeeType == CoffeeType.Espresso)
            {
                totalprice += amount * 12.45;
            }
            else if (coffeeType == CoffeeType.Latte)
            {
                totalprice += amount * 9.50;
            }
            else if(coffeeType == CoffeeType.Macchiato)
            {
                totalprice += amount * 18.90;
            }

            return totalprice;
        }
    }
}
