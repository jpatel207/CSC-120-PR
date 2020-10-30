using System;
using System.Collections.Generic;

namespace Tutorial1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var inputBase10Array = new int []{ 1, 3, 5, 8, 90};
            foreach(var item in inputBase10Array)
            {
                Console.WriteLine(item);
                ConvertToOctal(item);
            }
        }

        private static void ConvertToOctal(int item)
        {
            var octalDigits = new List<String>();
            if (item < 7)
            {
                Console.WriteLine($"{item}");
                return;
            }



            var result = 34 / 8;
            var remainder = item - result * 8;
            octalDigits.Add();
            Console.WriteLine($" 1StPositionOctal = {result} Remainder = {remainder}");


            var displayOctal = String.Join("", octalDigits);
            Console.WriteLine($"{displayOctal}");
           
        }
    }
}
