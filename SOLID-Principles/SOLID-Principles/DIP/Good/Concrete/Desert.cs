using System;
using System.Collections.Generic;
using System.Text;
using SOLID_Principles.DIP.Good.Abstract;

namespace SOLID_Principles.DIP.Good.Concrete
{
   public class Desert:IProduct
   {
       public string GetCookingInstructions()
       {
           return "Tatlı Tarifi";
       }
   }
}
