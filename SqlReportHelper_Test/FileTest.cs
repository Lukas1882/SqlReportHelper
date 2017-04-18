using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using SqlReportHelper.Models;
using SqlReportHelper.Common;
using System.IO;

namespace SqlReportHelper_Test
{
    public class FileTest
    {
        [Fact]
        public void ReadSetting_ReadGoodFile()
        {
            AppSetting setting = FileHelper.ReadSetting(FileHelper.GetRootPath() + "/Files/GoodSetting.json");

            Assert.Equal(setting.overWriteFile, true);
            Assert.Equal(setting.connectionString, "this is a test string");
        }
    }
}
