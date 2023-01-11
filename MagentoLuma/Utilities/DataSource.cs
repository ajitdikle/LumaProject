using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagentoLuma.Utilities
{
    public class DataSource
    {
        public static object[] ValidLoginData()
        {


            string[] dataset1 = new string[2];
            dataset1[0] = "rahul1309@gmail.com";
            dataset1[1] = "Rahul@123";


            string[] dataset2 = new string[2];
            dataset2[0] = "roni_cost@example.com";
            dataset2[1] = "roni_cost3@example.com";



            object[] allDataSet = new object[2];
            allDataSet[0] = dataset1;
            allDataSet[1] = dataset2;

            return allDataSet;
        }

        public static object[] ValidLoginData1()
        {
            object[] data = ExcelUtil.GetSheetIntoObjectArray

                (@"C:\Users\ajitd\Desktop\backup files\desktop files\CSharp\AutomationMagentoLuma\MagentoLuma\TestData\LumaSheet.xlsx", "ValidLoginData");

            return data;
        }
    }
}
