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
        public static void ExportFile(Script script)
        {
            ExcelPackage xp = new ExcelPackage();
            ExcelWorksheet ws = xp.Workbook.Worksheets.Add("1st");
            Stream stream = File.Create(AppModel.reportFolder + "report.xlsx");
            xp.SaveAs(stream);
            xp.Dispose(); 
        }
    }
}
