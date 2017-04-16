using System;
using SqlReportHelper.Common;
using SqlReportHelper.Models;
using System.Collections.Generic;

namespace SqlReportHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read setting from json file and sync to app model.
            AppSetting setting = FileHelper.ReadSetting();
            setting.UpdateAppModel();
            // Get the list of the scripts
            List<Script> scripts = FileHelper.ReadScripts();
            // Run scripts and get the sql data.
            DataHelper.ExecuteScripts(scripts);
            Console.WriteLine("\n");
            // Export the script sql data into excel.
            ExcelHelper.ExportFiles(scripts);

            Console.ReadKey();
        }
    }
}