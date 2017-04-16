using System;
using SqlReportHelper.Common;
using SqlReportHelper.Models;
 
namespace SqlReportHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        AppSetting setting =    FileHelper.ReadSetting();
            ExcelHelper.ExportFile(null);
          DataHelper.ExecuteScript("SELECT * FROM[WhereEat].[Common].users", setting);
        }
    }
}