using System;
using System.Collections.Generic;
using System.Text;
using SOLID_Principles.ISP.Good.Abstract;

namespace SOLID_Principles.ISP.Good.Concrete
{
    public class Penguin:IFlightlessBird

    {
        public string Walk()
        {
            return "Can Walk";
        }
    }
}
