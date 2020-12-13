using LogicCircuit.Gates.Composite;
using LogicCircuit.Gates.Simple;
using LogicCircuit.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartB
{
    class Identity
    {
        public bool SetInputX { get; set; }

        public bool SetInputY { get; set; }

        public bool orIdentity()
        {
            var result = true;
            var or = new OR();
            or.SetInputA(SetInputX);
            or.SetInputB(SetInputY);
            result = or.Output.State;
            return result;
        }

        public bool norIdentity()
        {
            var result = true;
            //old code that does the same using only simple gates
            //var orResult = true;
            //var or = new OR();
            //var not = new NOT();
            //or.SetInputA(SetInputX);
            //or.SetInputB(SetInputY);
            //orResult = or.Output.State;
            //not.SetInputA(orResult);
            //result = not.Output.State;
            var nor = new NOR();
            nor.InputA.State = SetInputX;
            nor.InputB.State = SetInputY;
            result = nor.Output.State;
            return result;
        }

        public bool notXIdentity()
        {
            var result = true;
            var not = new NOT();
            not.SetInputA(SetInputX);
            result = not.Output.State;
            return result;
        }

        public bool notYIdentity()
        {
            var result = true;
            var not = new NOT();
            not.SetInputA(SetInputY);
            result = not.Output.State;
            return result;
        }

        public bool andNotIdentity()
        {
            var result = true;
            var and = new AND();
            var SetInputX = notXIdentity();
            var SetInputY = notYIdentity();
            and.SetInputA(SetInputX);
            and.SetInputB(SetInputY);
            result = and.Output.State;
            return result;


        }

        public bool orNotIdentity()
        {
            var result = true;
            var or = new OR();
            var SetInputX = notXIdentity();
            var SetInputY = notYIdentity();
            or.SetInputA(SetInputX);
            or.SetInputB(SetInputY);
            result = or.Output.State;
            return result;

        }

        public bool nandIdentity()
        {
            var result = true;
            //old code that does the same using only simple gates
            //var andResult = true;
            //var and = new AND();
            //var not = new NOT();
            //and.SetInputA(SetInputX);
            //and.SetInputB(SetInputY);
            //andResult = and.Output.State;
            //not.SetInputA(andResult);
            //result = not.Output.State;
            var nand = new NAND();
            nand.InputA.State = SetInputX;
            nand.InputB.State = SetInputY;
            result = nand.Output.State;
            return result;
        }

    }
}
