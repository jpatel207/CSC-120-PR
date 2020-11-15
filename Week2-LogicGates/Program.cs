﻿using LogicCircuit.Abstractions.Gates;
using LogicCircuit.Gates.Composite;
using LogicCircuit.Gates.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//The LogicCircuit code downloaded from the provided Github link takes in boolean values as input and follows a logic circuit board with 
//AND, NOR, OR, NAND, NOR, XNOR, and XOR gates. 

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
            TestANDOR();
            TestNAND();

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

        private static void TestANDOR()
        {
            var truthTable = new List<Input>();
            truthTable.Add(new Input() { InputA = true, InputB = true });
            truthTable.Add(new Input() { InputA = false, InputB = true });
            truthTable.Add(new Input() { InputA = true, InputB = false });
            truthTable.Add(new Input() { InputA = false, InputB = false });
            foreach (var i in truthTable)
            {
                var andGate = new AND();
                andGate.SetInputA(i.InputA);
                andGate.SetInputB(i.InputB);
                var andResult = andGate.Output.State;
                var inputString = i.InputA.ToString() + "|" + i.InputB.ToString();
                Console.WriteLine("AND Gate with inputs {0}: {1}", inputString, andResult.ToString());

                //re-do using functions from logiccircuits code
                var nandGate = new NAND();
                //SetInputA method/function not applicable to composite gates?
                Console.WriteLine("NAND Gate with inputs {0}: {1}", inputString, nandResult.ToString());

            }
            foreach (var j in truthTable)
            {
                var orGate = new OR();
                orGate.SetInputA(j.InputA);
                orGate.SetInputB(j.InputB);
                var orResult = orGate.Output.State;
                var inputString = j.InputA.ToString() + "|" + j.InputB.ToString();
                Console.WriteLine("OR Gate with inputs {0}: {1}", inputString, orResult.ToString());

            }
              
    }
        private static void TestNAND()
        {
 
        }
    }
}
