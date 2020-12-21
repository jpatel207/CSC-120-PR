using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7
{
    class Calculate
    {
        //contains code that does the calculation of the current using the given inputs
        //see screenshot of circuit to better visualize it and how Current() method works
        public double SetV { get; set; }
        public double SetR1 { get; set; }
        public double SetR2 { get; set; }
        public double SetR3 { get; set; }
        public double SetR4 { get; set; }
        public double SetR5 { get; set; }
        public double SetR6 { get; set; }
        public double SetR7 { get; set; }
        public double SetR8 { get; set; }
        public double SetR9 { get; set; }

        public double Current()
        {
            var Req1 = SetR2 + SetR3 + SetR4; //series
            var Req2 = 1 / ((1 / Req1) + (1 / SetR6)); //parallel
            var Req3 = Req2 + SetR5; //series
            var Req4 = SetR7 + SetR8; //series
            var Req5 = 1 / ((1 / Req3) + (1 / (Req4))); //parellel
            var Req = SetR1 + Req4 + SetR9; //Ohm's Law
            double current = SetV / Req; //current = V/R
            return current;

        }
    }
}
