using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimulateMemory();
            //Conversion();
            var inputPutDataFile = @"C:\Data\inputdata.txt"; //creates string of the inputdata location to be used for ReadTruthTableData method -> FileStream
            var truthTableInputs = Storage.ReadTruthTableData(inputPutDataFile); //list of converted boolean values made using ReadTruthTableData method in Storage class
            var rowCount = 0;
            var storedValue = Storage.ReadData();
            if(storedValue >= 8)
            {
                storedValue = 0; //resets back to beginning of table
            }
            foreach (var input in truthTableInputs) //reads the data from the file and use it as the input for logic circuits
            {
                //Console.WriteLine($"{input.A}, {input.X}, {input.D}, {input.R}"); //prints each row/column of converted boolean values

                var identity = new Identity() { SetInputA = input.A, SetInputD = input.D, SetInputX = input.X, SetInputR = input.R };
                var output = identity.Validate();
                var compareOutput = output == identity.SetInputR; //outputs true if the output generated using logic circuits matches the output value from the table
                Console.WriteLine($" A  = {identity.SetInputA }," +
                                  $" D = {identity.SetInputD}," +
                                  $" X = {identity.SetInputX}, " +
                                  $" Gate Output = {output}, " +
                                  $" Table Output = {identity.SetInputR}, " +
                                  $" Matching Outputs = {compareOutput} ");
                rowCount++;
            }
        }



        private static void Conversion()
        {
            var value = "1";
            var convertedValue = Utility.ConvertToBoolean(value);

            Console.WriteLine($"Conversion from string {value} to binary {convertedValue}");


            var bit = Utility.ConvertToBit(convertedValue);
            Console.WriteLine($"Conversion from Boolean {convertedValue} to Bit {bit}");

        }

        private static void SimulateMemory()
        {
            var a = 100;
            var storedValue = Storage.ReadData(); //integer converted from text file string
            if (storedValue > 0)
            {
                a = storedValue;
                Console.WriteLine($"Stored Value {a}");
                Console.WriteLine($"Press Any Key to continue");
                Console.ReadLine(); //continues program when user presses any key
            }
            for (int i = storedValue; i < 10000; i++)
            {
                Storage.SaveData(a); //saves mystore.txt updated with last value that increments by one each time (memory like)
                Console.WriteLine($"Print Current Stored Value {i}");
                a = i;
            }

            Console.WriteLine($"Stored Value {a}");
        }
    }
}
