using System;
using System.Diagnostics.Tracing;

namespace Week1_DecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var decimalNumber = 239;

            // Step one you need to get each digit
            // The first step is to convert it to value to string -> character
            // So that you can get to each character 2 3 and 9

            var characterArray = decimalNumber.ToString().ToCharArray();
            var result = 0;
            var maxpower = characterArray.Length;
            var counter = 0;
            // Test to see if this is what you want
            foreach(var item in characterArray)
            {
                // find length of characterArray, make the first index the highest power and works backwards
                var digit = int.Parse(item.ToString());
                var power = Math.Pow(10, maxpower - ++counter);
                result = (int)(digit * power);

                // now print each character to console
                Console.WriteLine(item);
            }
            Console.WriteLine(result);

        }
    }
}
