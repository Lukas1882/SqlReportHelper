using System;
using System.Collections.Generic;
using System.Text;
using SqlReportHelper.Models;
using Newtonsoft.Json;

namespace SqlReportHelper.Common
{
    class FileHelper
    {
        public static Setting ReadSetting()
        {
            string fileStr = String.Empty;
            try
            {
              fileStr = System.IO.File.ReadAllText(HelperModel.settingPath);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                throw ex;
            }

            try
            {
                Setting setting = JsonConvert.DeserializeObject<Setting>(fileStr);
                return setting;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
