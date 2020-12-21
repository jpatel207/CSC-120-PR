using LogicCircuit.Gates.Composite;
using LogicCircuit.Gates.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8
{
    class Identity
    {
        public bool SetInputR { get; set; }

        public bool SetInputS { get; set; }

        public bool SetInputQ { get; set; }

        public bool SetInputQ_not { get; set; }

        public bool nandIdentityS()
        {
            var result = true;
            var nand = new NAND();
            nand.InputA.State = SetInputS;
            nand.InputB.State = SetInputQ_not;
            result = nand.Output.State;
            return result;
        }
        public bool nandIdentityR()
        {
            var result = true;
            var nand = new NAND();
            nand.InputA.State = SetInputR;
            nand.InputB.State = SetInputQ;
            result = nand.Output.State;
            return result;
        }

        public bool norIdentityS()
        {
            var result = true;
            var nor = new NOR();
            nor.InputA.State = SetInputS;
            nor.InputB.State = SetInputQ;
            result = nor.Output.State;
            return result;
        }

        public bool norIdentityR()
        {
            var result = true;
            var nor = new NOR();
            nor.InputA.State = SetInputR;
            nor.InputB.State = SetInputQ_not;
            result = nor.Output.State;
            return result;
        }
    }
}
