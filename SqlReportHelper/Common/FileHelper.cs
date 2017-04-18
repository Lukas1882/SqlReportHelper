using System;
using System.Collections.Generic;
using System.Text;
using SqlReportHelper.Models;
using Newtonsoft.Json;
using System.IO;

namespace SqlReportHelper.Common
{
    public class FileHelper
    {
        public static AppSetting ReadSetting(string filePath)
        {
            string fileStr = String.Empty;
            try
            {
              fileStr = File.ReadAllText(filePath);
            }
            catch (FileNotFoundException ex)
            {
                throw ex;
            }
            try
            {
                AppSetting setting = JsonConvert.DeserializeObject<AppSetting>(fileStr);
                return setting;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Script> ReadScripts()
        {
            List<Script> scripts = new List<Script>();
            if (!Directory.Exists(AppModel.scriptFolder))
                Directory.CreateDirectory(AppModel.scriptFolder);
            foreach (string filePath in Directory.GetFiles(AppModel.scriptFolder))
            {
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                scripts.Add(new Script(fileName, File.ReadAllText(filePath)));
            }
            return scripts;
        }

        public static string GetRootPath()
        {
            return AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("bin"));
        }
    }
}
