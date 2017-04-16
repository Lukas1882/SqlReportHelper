using System;
using System.Collections.Generic;
using System.Text;
using OfficeOpenXml;
using System.IO;
using SqlReportHelper.Models;

namespace SqlReportHelper.Common
{
    class ExcelHelper
    {
        internal static void ExportFiles(List<Script> scripts)
        {
            foreach (Script script in scripts)
            {
                ExportFile(script);
            }
        }

        public static void ExportFile(Script script)
        {
            ExcelPackage xp = new ExcelPackage();
            ExcelWorksheet ws = xp.Workbook.Worksheets.Add(DateTime.Now.ToString());
            ws.Cells["A1"].LoadFromDataReader(script.sqlData,true);
            Stream stream = File.Create(AppModel.reportFolder + script.name + ".xlsx");
            ws.Cells.AutoFitColumns();
            ws.Row(1).Style.Font.Bold = true;
            xp.SaveAs(stream);
            xp.Dispose();
        }
    }
}
