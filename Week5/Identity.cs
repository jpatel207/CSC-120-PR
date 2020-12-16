using LogicCircuit.Gates.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class Identity
    {
        public bool SetInputD { get; set; }

        public bool SetInputA { get; set; }

        public bool SetInputX { get; set; }

        public bool SetInputR { get; set; }

        public bool Validate() //returns output of logic circuits based on boolean equation of L = D + A*X_NOT
        {
            var result = true;

            var or = new OR();
            var not = new NOT();
            var and = new AND();

            not.SetInputA(SetInputX);
            var xNOT = not.Output.State;
            and.SetInputA(SetInputA);
            and.SetInputB(xNOT);
            var outputfromAND = and.Output.State;
            or.SetInputA(outputfromAND);
            or.SetInputB(SetInputD);
            result = or.Output.State;

            return result;
        }
    }
}
