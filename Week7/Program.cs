using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//The program takes in 10 different inputs for voltage through a text input file with a total of 10 different parameters (voltage + 9 resistors).
//The program takes into consideration whether the different resistors are in series or parallel which affects how current is calculated.
//The final output of the program is a text file that contains the value of the current (I) output.
//A X-Y graph of this output is included in the program directory folder.
//I was still confused about the instructions, such as what was exactly expected to be the input or output. 
//I kept the resistor values the same thinking it would be easier to create an X-Y plot of changing voltage vs current.
//If it was expected for me to change the resistor values, the program is designed to easily do that too, I just wasn't sure exactly what I needed to do for this assignment.

namespace Week7
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputCircuit = Path.Combine(Directory.GetCurrentDirectory(), "input.txt");
            var circuitTableInputs = Storage.ReadCircuitTable(inputCircuit);
            var outputFile = Path.Combine(Directory.GetCurrentDirectory(), "Output.txt");
            var sb = new StringBuilder();
            sb.AppendLine("Voltage,Current");
            foreach (var input in circuitTableInputs)
            {
                var calculate = new Calculate() { SetV = input.V, SetR1 = input.R1, SetR2 = input.R2, SetR3 = input.R3, 
                                                    SetR4 = input.R4, SetR5 = input.R5, SetR6 = input.R6, SetR7 = input.R7, SetR8 = input.R8, SetR9 = input.R9 };
                var current = calculate.Current();
                Console.WriteLine($"Voltage = {calculate.SetV}, " + $"Current = {current}");
                var output = $"{calculate.SetV}," + $"{current}";
                sb.AppendLine(output);
            }
            File.WriteAllText(outputFile, sb.ToString());

        }
    }
}
