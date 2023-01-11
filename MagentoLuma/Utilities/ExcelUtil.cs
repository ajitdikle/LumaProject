﻿using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagentoLuma.Utilities
{
    public class ExcelUtil
    {
        public static object[] GetSheetIntoObjectArray(string file, string sheetName)
        {
            using (XLWorkbook book = new XLWorkbook(file))
            {
                IXLWorksheet sheet = book.Worksheet(sheetName);

                IXLRange range = sheet.RangeUsed();

                int rowCount = range.RowCount();
                int columnCount = range.ColumnCount();

                object[] allData = new object[rowCount - 1];

                for (int r = 2; r <= rowCount; r++)
                {
                    string[] arr = new string[columnCount];

                    for (int c = 1; c <= columnCount; c++)
                    {
                        arr[c - 1] = range.Cell(r, c).GetString();

                    }
                    allData[r - 2] = arr;
                }
                return allData;
            }


        }


    }
}
