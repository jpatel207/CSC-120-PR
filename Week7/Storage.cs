using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7
{
    class Storage
    {
        //reads the input file with varying voltage values (or resistor values if applicable)
        //user can change the resistor values in text file and it should work the same
        //but for purpose of creating an X-Y plot of voltage vs current, the resistor values were kept the same

        public static List<Circuit> ReadCircuitTable(string dataPath)
        {
            var inputList = new List<Circuit>();
            var fs = new FileStream(dataPath, FileMode.Open); 
            var sr = new StreamReader(fs);
            sr.ReadLine(); //skips first line
            while (sr.Peek() != -1)
            {
                var inputRow = new Circuit();

                var data = sr.ReadLine();
                var dataElements = data.Split(',');

                inputRow.V = Utilities.ConvertToDouble(dataElements[0]);
                inputRow.R1 = Utilities.ConvertToDouble(dataElements[1]);
                inputRow.R2 = Utilities.ConvertToDouble(dataElements[2]);
                inputRow.R3 = Utilities.ConvertToDouble(dataElements[3]);
                inputRow.R4 = Utilities.ConvertToDouble(dataElements[4]);
                inputRow.R5 = Utilities.ConvertToDouble(dataElements[5]);
                inputRow.R6 = Utilities.ConvertToDouble(dataElements[6]);
                inputRow.R7 = Utilities.ConvertToDouble(dataElements[7]);
                inputRow.R8 = Utilities.ConvertToDouble(dataElements[8]);
                inputRow.R9 = Utilities.ConvertToDouble(dataElements[9]);


                inputList.Add(inputRow);
            }

            sr.Close();
            fs.Close();

            return inputList;
        }
    }
}
