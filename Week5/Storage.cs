using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    public class Storage
    {
        static string STORAGE = "MyStore.txt"; //found this in bin folder with value of 336 - got wiped after running program for some reason
        public static bool SaveData(int val)
        {
            var fs = new FileStream(STORAGE, FileMode.Create);
            var sw = new StreamWriter(fs);
            sw.Write( val);
            sw.Flush();
            sw.Close();
            fs.Close();
            return true;
        }

       

        public static int ReadData()
        {
            if (!File.Exists(STORAGE))
            {
                return 0;
            }
            var data = File.ReadAllText(STORAGE);
            var inValue = int.Parse(data); //converts to 32 bit integer
            return inValue;
        }


      
        public static bool SaveTruthTableData(int val1, int val2, int val3, int result)
        {
            var fs = new FileStream(STORAGE, FileMode.Create);
            var sw = new StreamWriter(fs);
            sw.WriteLine($"{val1}, {val2}, {val3}, {result}");
            sw.Flush();
            sw.Close();
            fs.Close();
            return true;
        }

        public static bool SaveTruthTableData(TruthTable tt )
        {
            
            return SaveTruthTableData(
                                        tt.A ? 1 : 0,
                                        tt.X ? 1 : 0, 
                                        tt.D ? 1 : 0,
                                        tt.R ? 1 : 0
                                        );
        }
        public static TruthTable ReadTruthTable()
        {
            var inputRow = new TruthTable();
            if (!File.Exists(STORAGE))
            {
                return inputRow;
            }
            var data = File.ReadAllText(STORAGE);
            var dataElements = data.Split(','); // 0,1,0,1  will be split into arrays

            inputRow.A = Utility.ConvertToBoolean(dataElements[0]);
            inputRow.X = Utility.ConvertToBoolean(dataElements[1]);
            inputRow.D = Utility.ConvertToBoolean(dataElements[2]);
            inputRow.R = Utility.ConvertToBoolean(dataElements[3]);
            return inputRow;
        }

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
                //Console.Write(dataElements[0]);

                inputRow.A = Utility.ConvertToBoolean(dataElements[0]); //from Utility class - ConvertToBoolean - checks if dataElement is 1 or 0 converts to boolean
                inputRow.D = Utility.ConvertToBoolean(dataElements[1]);
                inputRow.X = Utility.ConvertToBoolean(dataElements[2]);
                inputRow.R = Utility.ConvertToBoolean(dataElements[3]);
                inputList.Add(inputRow); //adds all of the converted rows to the previously created and empty inputList
            }

            sr.Close();
            fs.Close();

            return inputList;
        }

    }
}
