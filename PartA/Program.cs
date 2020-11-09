using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartA
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = new List<IdentityInput>();
            inputs.Add(new IdentityInput() { A = false, D = false, X = false });
            inputs.Add(new IdentityInput() { A = false, D = false, X = true });
            inputs.Add(new IdentityInput() { A = false, D = true, X = false });

            foreach (var item in inputs)
            {
                var identity = new Identity() { SetInputA = item.A, SetInputD = item.D, SetInputX = item.X };
                //identity.SetInputA = item.A;
                //identity.SetInputD = item.D;
                //identity.SetInputX = item.X;
                var result = identity.Validate();
            }
        }
    }
}
