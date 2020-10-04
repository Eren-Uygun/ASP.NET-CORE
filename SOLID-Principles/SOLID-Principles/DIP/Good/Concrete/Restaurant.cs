using System;
using System.Collections.Generic;
using System.Text;
using SOLID_Principles.DIP.Good.Abstract;

namespace SOLID_Principles.DIP.Good.Concrete
{
   public class Restaurant
   {
       List<IProduct> products;

       public Restaurant()
       {
           this.products = new List<IProduct>();
       }


      public string GenerateInstructions()
      {
          string instructions = string.Empty;

          foreach (var item in products)
          {
              instructions += " " + item.GetCookingInstructions();
          }

          return instructions;
      }
   }
}
