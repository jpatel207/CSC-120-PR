﻿using LogicCircuit.Gates.Simple;
using LogicCircuit.Infrastructure;

namespace LogicCircuit.Alu.Add
{
    public class FullAdder
    {
        private readonly HalfAdder halfAdder1 = new HalfAdder();
        private readonly HalfAdder halfAdder2 = new HalfAdder();
        private readonly OR or = new OR();

        public InputPin InputA { get; private set; }
        public InputPin InputB { get; private set; }
        public InputPin CarryIn { get; private set; }

        public OutputPin CarryOver { get; private set; }
        public OutputPin Sum { get; private set; }

        public FullAdder()
        {
            InputA = halfAdder1.InputA;
            InputB = halfAdder1.InputB;
            halfAdder1.Sum.ConnectTo(halfAdder2.InputA);
            CarryIn = halfAdder2.InputB;
            or.InputA.ConnectTo(halfAdder1.CarryOver);
            or.InputB.ConnectTo(halfAdder2.CarryOver);
            CarryOver = or.Output;
            Sum = halfAdder2.Sum;
        }
    }
}
