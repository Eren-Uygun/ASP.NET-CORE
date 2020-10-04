using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.OCP.Good.Abstract
{
    // eklenecek tüm kahveler bu soyut sınıftan miras alacak ve her birinin kendi hesaplama metodu olacaktır.
   public abstract class GoodCoffee
   {
       public abstract double GetTotalPrice(double amount);
   }
}
