using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//The following program takes input text files for SR flip-flop circuits with NOR or NAND gates. It tests if the NOR or NAND functions yield the proper SR circuit function.
//The pre-defined text files contain values that work with the respective gates, but you could use any text file with columns of 0s and 1s to test if they are valid inputs/outputs.
//The program checks for things like if the Q and Q-not outputs are both true or false, which would not be valid with NAND and NOR SR gates, respectively.
//The output is printed in console and also written to a text file.

namespace Week8
{
    class Program
    {
        static void Main(string[] args)
        {

            var inputNOR = Path.Combine(Directory.GetCurrentDirectory(), "InputNOR.txt");
            var inputNAND = Path.Combine(Directory.GetCurrentDirectory(), "InputNAND.txt");
            var output = Path.Combine(Directory.GetCurrentDirectory(), "Output.txt");
            var truthTableNOR = Storage.ReadTruthTableData(inputNOR);
            var truthTableNAND = Storage.ReadTruthTableData(inputNAND);
            var outputMatch = false;
            var validOutputs = false;
            var nandString = "";
            var norString = "";
            var sb = new StringBuilder();
            var titleNAND = "SR Latch with NAND gates";
            var titleNOR = "SR Latch with NOR gates";
            Console.WriteLine(titleNAND);
            sb.AppendLine(titleNAND);

            for (int i = 0; i < truthTableNAND.Count; i++)
            {
                TruthTable input = truthTableNAND[i];
                var identityNand = new Identity() { SetInputS = input.S, SetInputR = input.R, SetInputQ = input.Q, SetInputQ_not = input.Q_not };
                var outputNandQ = identityNand.nandIdentityS();
                var outputNandQ_not = identityNand.nandIdentityR();
                if (outputNandQ == identityNand.SetInputQ && outputNandQ_not == identityNand.SetInputQ_not)
                {
                    outputMatch = true; //true if the outputs generated using the nor gates matches the actual Q or Q_not outputs
                }
                else
                {
                    outputMatch = false;
                }
                if (outputNandQ == true && outputNandQ_not == true) //checks if Q and not Q values are the same -> invalid in SR gate
                {
                    validOutputs = false;
                }
                else if (outputNandQ == false && outputNandQ_not == false) //checks if Q and not Q values are the same -> invalid in SR gate
                {
                    validOutputs = false;
                }
                else
                {
                    validOutputs = true;
                }
                    nandString = $" S  = {identityNand.SetInputS }," +
                    $" R = {identityNand.SetInputR} |" +
                    $" Q Output = {outputNandQ}," +
                    $" Q_not Output = {outputNandQ_not} |" +
                    $" Expected Output Match = {outputMatch} |" +
                    $" Valid = {validOutputs} ";
                Console.WriteLine(nandString);
                sb.AppendLine(nandString);
            }

            Console.WriteLine(titleNOR);
            sb.AppendLine(titleNOR);
            for (int i = 0; i < truthTableNOR.Count; i++)
            {
                TruthTable input = truthTableNOR[i];
                var identityNor = new Identity() { SetInputS = input.S, SetInputR = input.R, SetInputQ = input.Q, SetInputQ_not = input.Q_not };
                var outputNorQ = identityNor.norIdentityR();
                var outputNorQ_not = identityNor.norIdentityS();
                if (outputNorQ == identityNor.SetInputQ && outputNorQ_not == identityNor.SetInputQ_not)
                {
                    outputMatch = true; //true if the outputs generated using the nor gates matches the actual Q or Q_not outputs
                }
                else
                {
                    outputMatch = false;
                }
                if (outputNorQ == true && outputNorQ_not == true) //checks if Q and not Q values are the same -> invalid in SR gate
                {
                    validOutputs = false;
                }
                else if (outputNorQ == false && outputNorQ_not == false) //checks if Q and not Q values are the same -> invalid in SR gate
                {
                    validOutputs = false;
                }
                else
                {
                    validOutputs = true;
                }
                norString = $" S  = {identityNor.SetInputS}," +
                     $" R = {identityNor.SetInputR} |" +
                     $" Q Output = {outputNorQ}," +
                     $" Q_not Output = {outputNorQ_not} |" +
                     $" Expected Output Match = {outputMatch} |" +
                     $" Valid = {validOutputs} ";
                Console.WriteLine(norString);
                sb.AppendLine(norString);
            }
            File.WriteAllText(output, sb.ToString()); //outputs results to text file Output.txt
            Console.WriteLine("Output text file has been created in same directory.");
        }
    }
}
