using LogicCircuit.Gates.Simple;
using LogicCircuit.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartA
{
    public class Identity
    {
        public bool SetInputD { get; set; }

        public bool SetInputA { get; set; }

        public bool SetInputX { get; set; }

        public bool Validate()
        {
            var result = true;
            var or = new OR();
            var not = new NOT();
            var and = new AND();

            not.SetInputA(SetInputX);
            var xNOT = not.InputA;
            result = SetInputA;
            and.SetInputA(SetInputA);
            and.SetInputB(xNOT);
            var outputfromAND = and.Output.State;
            return result;
        }
    }
}
