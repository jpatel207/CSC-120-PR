using LogicCircuit.Abstractions.Gates;
using LogicCircuit.Gates.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

            TestCase1();
            TestCase2();
            TestCase3();
            TestCase4();
            TestCase5();

        }

        private static void TestCase1()
        {
            //State 1 false false
            var tester = new AND();
            tester.SetInputA(false);
            tester.SetInputB(false);
            var result = tester.Output;
            Console.WriteLine(result.State);
        }

        private static void TestCase2()
        {
            //State 2 false true
            var tester = new AND();
            tester.SetInputA(false);
            tester.SetInputB(true);
            var result = tester.Output;
            Console.WriteLine(result.State);
        }

        private static void TestCase3()
        {
            var myMatrixInput = new List<Input>();
            myMatrixInput.Add(new Input() { InputA = true, InputB = true });
            myMatrixInput.Add(new Input() { InputA = false, InputB = true });
            myMatrixInput.Add(new Input() { InputA = true, InputB = false });
            myMatrixInput.Add(new Input() { InputA = false, InputB = false });
            foreach (var i in myMatrixInput)
            {
                var andGate = new AND();
                andGate.SetInputA(i.InputA);
                andGate.SetInputB(i.InputB);
                var result = andGate.Output.State;
                Console.WriteLine(result.ToString());
                var orGate = new OR();
                orGate.SetInputA(i.InputA);
                orGate.SetInputB(result);
                var orFinalOutput = orGate.Output.State;
                Console.WriteLine($"{i.InputA}, {i.InputB}, {result}, {i.InputA}, {orFinalOutput}");

            }
        }

        private static void TestCase4()
        {
            //State 4 true true
            var tester = new AND();
            tester.SetInputA(true);
            tester.SetInputB(true);
            var result = tester.Output;
            Console.WriteLine(result.State);
        }


        //If 
        private static void TestCase5()
        {
            var tester = new NOT();
            tester.SetInputA(false);
            var result = tester.Output;
            Console.WriteLine(result.State);
            //true
        }
        private static void TestCase6()
        {
            var tester = new NOT();
            tester.SetInputA(true);
            var result = tester.Output;
            Console.WriteLine(result.State);
            //false
        }
        /// <summary>
        /// if one is true in an OR than both is true position doesn't matter
        /// 
        /// </summary>
        private static void TestCase7()
        {
            var tester = new OR();
            tester.SetInputA(false);
            tester.SetInputB(false);
            var result = tester.Output;
            Console.WriteLine(result.State);
            // false
        }




    }
}
