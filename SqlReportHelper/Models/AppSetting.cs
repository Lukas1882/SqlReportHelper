using System;
using System.Collections.Generic;
using System.Text;

namespace SqlReportHelper.Models
{
    public class AppSetting
    {
        public  string connectionString { get; set; }
        public  bool overWriteFile { get; set; }
        public  bool addNewSheet { get; set; }

        public void UpdateAppModel()
        {
            AppModel.connectionString = connectionString;
            AppModel.overWriteFile = overWriteFile;
            AppModel.addNewSheet = addNewSheet;
        }
    }

}
