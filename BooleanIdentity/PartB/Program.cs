using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartB
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = new List<IdentityInput>();
            inputs.Add(new IdentityInput() { X = false, Y = false });
            inputs.Add(new IdentityInput() { X = false, Y = true });
            inputs.Add(new IdentityInput() { X = true, Y = false });
            inputs.Add(new IdentityInput() { X = true, Y = true });

            foreach (var item in inputs)
            {
                var identity = new Identity() { SetInputX = item.X, SetInputY = item.Y };
                var orOutput = identity.orIdentity();
                var norOutput = identity.norIdentity();
                var notXOutput = identity.notXIdentity();
                var notYOutput = identity.notYIdentity();
                var andNotOutput = identity.andNotIdentity();
                var orNotOutput = identity.orNotIdentity();
                var nandOutput = identity.nandIdentity();
                Console.WriteLine($" X  = {identity.SetInputX }," +
                                    $" Y = {identity.SetInputY} |" +
                                    $" OR Output = {orOutput} |" +
                                    $" NOR Output = {norOutput} |" +
                                    $" NOT X Output = {notXOutput} |" +
                                    $" NOT Y Output = {notYOutput} |" +
                                    $" NOT X AND NOT Y Output = {andNotOutput} |" +
                                    $" NOT X OR NOT Y Output = {orNotOutput} |" +
                                    $" NAND Output = {nandOutput} |");

                //code for checking DeMorgan's Theorem: NOR = not X and not Y
                //NAND = not X or not Y
                //will not print if gate functions are setup correctly
                if (norOutput != andNotOutput)
                {
                    Console.WriteLine("NOR gate output does not match output of not X and not Y");
                }    
                if (nandOutput != orNotOutput)
                {
                    Console.WriteLine("NAND gate output does not match output of not X or not Y");
                }
            }
        }
    }
}
