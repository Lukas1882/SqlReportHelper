using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SqlReportHelper.Models
{
    class AppModel
    {
        public static string settingPath = "Setting.json";
        public static string scriptFolder = Directory.GetCurrentDirectory() + "/Scripts/";
        public static string reportFolder = Directory.GetCurrentDirectory() +"/Reports/";
        public static string connectionString { get; set; }
        public static bool overWriteFile { get; set; }
        public static bool addNewSheet { get; set; }
    }
}
