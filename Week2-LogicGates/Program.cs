using LogicCircuit.Abstractions.Gates;
using LogicCircuit.Gates.Composite;
using LogicCircuit.Gates.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//Summary of LogicCircuits code:
//The LogicCircuit code downloaded from the provided Github link takes in boolean values as input and follows a logic circuit board with 
//AND, NOR, OR, NAND, NOR, XNOR, and XOR gates. There are several functions and methods that can be utilized to design your own program to test 
//out boolean logic values as if you are working with a circuit board. 

namespace Week2_LogicGates
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) State : (false) + (false) =  (false)
            // 2) State : (false) + (true)  =  (false)
            // 3) State : (true)  + (false) =  (false)
            // 4) State : (true)  + (true)  =  (true)

            TestNOT1();
            TestNOT2();
            TestMultiple();

        }

        private static void TestNOT1()
        {
            var tester = new NOT();
            tester.SetInputA(true);
            var result = tester.Output.State;
            Console.WriteLine("NOT Gate with input True: " + result.ToString());

        }

        private static void TestNOT2()
        {
            var tester = new NOT();
            tester.SetInputA(false);
            var result = tester.Output.State;
            Console.WriteLine("NOT Gate with input False: " + result.ToString());

        }

        private static void TestMultiple()
        {
            var truthTable = new List<Input>();
            truthTable.Add(new Input() { InputA = true, InputB = true });
            truthTable.Add(new Input() { InputA = false, InputB = true });
            truthTable.Add(new Input() { InputA = true, InputB = false });
            truthTable.Add(new Input() { InputA = false, InputB = false });

            //AND GATE
            foreach (var i in truthTable)
            {
                var andGate = new AND();
                andGate.SetInputA(i.InputA);
                andGate.SetInputB(i.InputB);
                var andResult = andGate.Output.State;
                var inputString = i.InputA.ToString() + "|" + i.InputB.ToString();
                Console.WriteLine("AND Gate with inputs {0}: {1}", inputString, andResult.ToString());
            }

            //OR GATE
            foreach (var i in truthTable)
            {
                var orGate = new OR();
                orGate.SetInputA(i.InputA);
                orGate.SetInputB(i.InputB);
                var orResult = orGate.Output.State;
                var inputString = i.InputA.ToString() + "|" + i.InputB.ToString();
                Console.WriteLine("OR Gate with inputs {0}: {1}", inputString, orResult.ToString());

            }

            //NAND GATE
            foreach (var i in truthTable)
            {
                var nandGate = new NAND();
                nandGate.InputA.State = i.InputA;
                nandGate.InputB.State = i.InputB;
                var nandResult = nandGate.Output.State;
                var inputString = i.InputA.ToString() + "|" + i.InputB.ToString();
                Console.WriteLine("NAND Gate with inputs {0}: {1}", inputString, nandResult.ToString());
            }

            //NOR GATE
            foreach (var i in truthTable)
            {
                var norGate = new NOR();
                norGate.InputA.State = i.InputA;
                norGate.InputB.State = i.InputB;
                var norResult = norGate.Output.State;
                var inputString = i.InputA.ToString() + "|" + i.InputB.ToString();
                Console.WriteLine("NOR Gate with inputs {0}: {1}", inputString, norResult.ToString());
            }

            //XOR Gate
            foreach (var i in truthTable)
            {
                var xorGate = new XOR();
                xorGate.InputA.State = i.InputA;
                xorGate.InputB.State = i.InputB;
                var norResult = xorGate.Output.State;
                var inputString = i.InputA.ToString() + "|" + i.InputB.ToString();
                Console.WriteLine("XOR Gate with inputs {0}: {1}", inputString, xorGate.ToString());
            }

            //XNOR Gate
            foreach (var i in truthTable)
            {
                var xnorGate = new XNOR();
                xnorGate.InputA.State = i.InputA;
                xnorGate.InputB.State = i.InputB;
                var norResult = xnorGate.Output.State;
                var inputString = i.InputA.ToString() + "|" + i.InputB.ToString();
                Console.WriteLine("XNOR Gate with inputs {0}: {1}", inputString, xnorGate.ToString());
            }

        }

    }
}