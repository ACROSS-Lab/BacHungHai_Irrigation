using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DHI.Generic.MikeZero;
using DHI.Generic.MikeZero.DFS;
using DHI.Generic.MikeZero.DFS.dfsu;
using DHI.Generic.MikeZero.DFS.dfs123;

namespace MyCSharpDemoCalc
{
    /*
    public interface ICalc
    {
        string MySuperSmartFunctionIDontHaveInJava(string filename, string gate_name);
    }
    */
    public class DemoCalc //: ICalc
    {
        public string MySuperSmartFunctionIDontHaveInJava(string filename, string gate_name)
        {
            string result = "";
            // Open the file as a generic dfs file
            IDfsFile dfs0File = DfsFileFactory.DfsGenericOpen(filename);
            /*
            // Header information is contained in the IDfsFileInfo
            IDfsFileInfo fileInfo = dfs0File.FileInfo;
            int steps = fileInfo.TimeAxis.NumberOfTimeSteps;                   // 19

            // Information on each of the dynamic items, here the first one
            IDfsSimpleDynamicItemInfo dynamicItemInfo = dfs0File.ItemInfo[0];
            string nameOfFirstDynamicItem = dynamicItemInfo.Name;              // "Rain"
            DfsSimpleType typeOfFirstDynamicItem = dynamicItemInfo.DataType;   // Double
            ValueType valueType = dynamicItemInfo.ValueType;                   // StepAccumulated

            // Read data of first item, third time step (items start by 1, timesteps by 0),
            // assuming data is of type double.
            IDfsStaticItem  data = dfs0File.ReadStaticItem(0);//.ReadItemTimeStep(1, 2);
            object value1 = data.Data.GetValue(0);                                        // 0.36
            Console.WriteLine(value1);
            // Read data of first item, third time step (items start by 1, timesteps by 0),
            // converting data to double
            // IDfsItemData datag = dfs0File.ReadItemTimeStep(1, 2);
            // double value2 = System.Convert.ToDouble(datag.Data.GetValue(0));     // 0.36
            */

            IDfsFileInfo fileInfo = dfs0File.FileInfo;
            int steps = fileInfo.TimeAxis.NumberOfTimeSteps;
            //Console.WriteLine(steps);
            IDfsItemData data;
            for (int ii = 0; ii < steps; ii++)
            {
                IList<IDfsDynamicItemInfo> iill = dfs0File.ItemInfo.Where(i => i.Name.Contains(gate_name)).ToList();
                //IList<IDfsDynamicItemInfo> iill = dfs0File.ItemInfo;
                for (int j = 0; j < iill.Count; j++)
                {
                    data = dfs0File.ReadItemTimeStep(iill[j].ItemNumber, ii);
                    /*
                     * Console.WriteLine(iill[j].ItemNumber);
                    Console.WriteLine(iill[j].Name);
                    Console.WriteLine(data.Data.GetLength(0));
                    */
                    result += iill[j].ItemNumber + "\n";
                    result += iill[j].Name + "\n";
                    result += data.Data.GetLength(0) + "\n";


                    for (int i = 0; i < data.Data.GetLength(0); i++)
                    {

                        object value = data.Data.GetValue(i);
                        result += value + ";";
                        //Console.Write("\t\t"+value);
                    }
                    result += "\n";
                    //Console.WriteLine();
                }
            }
            return result;
        }
    }
}
