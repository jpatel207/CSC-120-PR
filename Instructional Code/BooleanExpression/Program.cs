using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = Compare(10, 200) 
                        || Compare(40,2) 
                        || Compare(-20, 2); //evaluates only first two
            Console.WriteLine(result);
            Console.Read();
        }


        private static bool Compare(int a, int b)
        {
            var result = a > b ? true : false; //inline if true return true, else false
            return result;
        }
    }
}
