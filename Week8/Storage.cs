using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8
{
    public class Storage
    {
        public static List<TruthTable> ReadTruthTableData(string dataPath) //inputPutDataFile is assigned here for dataPath
        {
            var inputList = new List<TruthTable>(); //creates new list called inputList that will later hold the boolean values
            var fs = new FileStream(dataPath, FileMode.Open); //opens text file
            var sr = new StreamReader(fs); //reads through previously created FileStream
            sr.ReadLine(); //skips first line
            while (sr.Peek() != -1) // peek and read till End of File - had to be corrected from != -1 (cause of null exception error)
            {
                var inputRow = new TruthTable(); //TruthTable() -> get; set; implementation

                var data = sr.ReadLine();
                //Console.WriteLine(data); //to test if while loop is working
                var dataElements = data.Split(','); // column will be split into array elements

                inputRow.S = Utility.ConvertToBoolean(dataElements[0]); //from Utility class - ConvertToBoolean - checks if dataElement is 1 or 0 converts to boolean
                inputRow.R = Utility.ConvertToBoolean(dataElements[1]);
                inputRow.Q = Utility.ConvertToBoolean(dataElements[2]);
                inputRow.Q_not = Utility.ConvertToBoolean(dataElements[3]);
                inputList.Add(inputRow); //adds all of the converted rows to the previously created and empty inputList
            }

            sr.Close();
            fs.Close();

            return inputList;
        }

    }
}
