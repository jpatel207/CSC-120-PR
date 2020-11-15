using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartA
{
    public class Program
    {
        static void Main(string[] args)
        {
            var inputs = new List<IdentityInput>();
            inputs.Add(new IdentityInput() { A = false, D = false, X = false });
            inputs.Add(new IdentityInput() { A = false, D = false, X = true });
            inputs.Add(new IdentityInput() { A = false, D = true, X = false });
            inputs.Add(new IdentityInput() { A = false, D = true, X = true });
            inputs.Add(new IdentityInput() { A = true, D = false, X = false });
            inputs.Add(new IdentityInput() { A = true, D = false, X = true });
            inputs.Add(new IdentityInput() { A = true, D = true, X = false });
            inputs.Add(new IdentityInput() { A = true, D = true, X = true });

            foreach (var item in inputs)
            {
                var identity = new Identity() { SetInputA = item.A, SetInputD = item.D, SetInputX = item.X };

                //same way as above in curly brackets (keeping this to remember for later)
                //identity.SetInputA = item.A;
                //identity.SetInputD = item.D;
                //identity.SetInputX = item.X;

                var output = identity.Validate();

                Console.WriteLine($" A  = {identity.SetInputA }," +
                                  $" D = {identity.SetInputD}," +
                                  $" X = {identity.SetInputX}, " +
                                  $" Output = {output}");
            }
        }
    }
}
