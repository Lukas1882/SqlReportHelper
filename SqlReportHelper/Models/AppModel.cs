using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SqlReportHelper.Models
{
    class AppModel
    {
        public static string settingPath = "Setting.json";
        public static string scriptFolder = Common.FileHelper.GetRootPath() + "/Scripts/";
        public static string reportFolder = Common.FileHelper.GetRootPath() + "/Reports/";
        public static string connectionString { get; set; }
        public static bool overWriteFile { get; set; }
        public static bool addNewSheet { get; set; }
    }
}
