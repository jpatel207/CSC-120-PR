using LogicCircuit.Gates.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    public class TruthTable
    {
        public Boolean A { get; set; }
        public Boolean X { get; set; }
        public Boolean D { get; set; }
        public Boolean R { get; set; }

        public bool Validate()
        {
            var result = true;

            var or = new OR();
            var not = new NOT();
            var and = new AND();

            not.SetInputA(X);
            var xNOT = not.Output.State;
            and.SetInputA(A);
            and.SetInputB(xNOT);
            var outputfromAND = and.Output.State;
            or.SetInputA(outputfromAND);
            or.SetInputB(D);
            result = or.Output.State;

            return result;
        }
    }

}
