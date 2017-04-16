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

            AppSetting setting = FileHelper.ReadSetting();
            List<Script> scripts = FileHelper.ReadScripts();
            DataHelper.ExecuteScripts(scripts,setting);
            ExcelHelper.ExportFiles(scripts);
            //DataHelper.ExecuteScript("SELECT * FROM [WhereEat].[Common].users", setting);
        }
    }
}