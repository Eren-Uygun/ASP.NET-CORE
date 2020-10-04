using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.DIP.Bad
{
   public class BadRestaurant
    {
        BadDesert desert = new BadDesert();
        BadMeat meat = new BadMeat();

        public string GenerateInstructions()
        {
            return desert.GetDesertCookingInstruction() + " " + meat.GetMeatCookingInstructions();
        }
    }
}
