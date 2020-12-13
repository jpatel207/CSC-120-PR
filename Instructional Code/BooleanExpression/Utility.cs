using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanExpression
{
    class Utility
    {
        public bool Compare(int a = 200, int b = 100)
        {
            var result = a > b ? true : false; //inline if
            return result;
        }
         public bool Compare(int a = 200, int b = 100, int c = 10)

        {
            var result = a > b ? true : false; //inline if
            //return result && ()
        }
}
}
