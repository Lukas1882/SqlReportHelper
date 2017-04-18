using System;
using System.Collections.Generic;
using System.Text;
using OfficeOpenXml;
using System.IO;
using SqlReportHelper.Models;


namespace SqlReportHelper.Common
{
    public class ExcelHelper
    {
        internal static void ExportFiles(List<Script> scripts)
        {
            foreach (Script script in scripts)
            {
                try
                {
                    ExportFile(script);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(script.name + " : Error. Message : " + ex.Message);
                }
            }
        }

        public static void ExportFile(Script script)
        {
            string filePath = AppModel.reportFolder + script.name + ".xlsx";
            ExcelPackage xp = new ExcelPackage();
            try
            {
                ExcelWorksheet ws = xp.Workbook.Worksheets.Add(DateTime.Now.ToString());
                ws.Cells["A1"].LoadFromDataReader(script.sqlData, true);
                if (!AppModel.overWriteFile)
                    filePath = GetReportName(filePath);
                Stream stream = File.Create(filePath);
                ws.Cells.AutoFitColumns();
                ws.Row(1).Style.Font.Bold = true;
                xp.SaveAs(stream);
                xp.Dispose();
                Console.WriteLine(script.name + " : Report created successfully.");
                Console.WriteLine("Report saved as : " + Path.GetFileName(filePath));
                Console.WriteLine("\n");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string GetReportName(string filePath)
        {
            // If the user setting is not overwrite and there is an existing file, create new file with timestamp.
            if ((!AppModel.overWriteFile) && File.Exists(filePath))
                return AppModel.reportFolder + Path.GetFileNameWithoutExtension(filePath) + "_" +  (DateTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx");
            return filePath;
        }
    }
}
