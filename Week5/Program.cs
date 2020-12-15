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

            foreach( var input in truthTableInputs) //reads the data from the file and use it as the input for logic circuits
            {
                //Console.WriteLine($"{input.A}, {input.X}, {input.D}, {input.R}"); //prints each row/column of converted boolean values

                //serves as memory, last row value saved to file to make sure program picks up where it left off
                //ideas: you can use the mystore.txt file as a sort of updating counter file - you won't print anything from it
                

                //input for logic circuits
                var identity = new TruthTable() { A = input.A, D = input.D, X = input.X, R = input.R };
                var output = identity.Validate();
                Console.WriteLine($" A  = {identity.A }," +
                                  $" D = {identity.D}," +
                                  $" X = {identity.X}, " +
                                  $" Gate Output = {output}, " +
                                  $" Table Output = {identity.R}");
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
            var storedValue = Storage.ReadData(); //ReadData() takes in that mystore.txt file integer and converts value to 32 bit integer
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
