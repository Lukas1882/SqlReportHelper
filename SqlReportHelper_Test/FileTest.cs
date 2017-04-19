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
        string goodSettingPath = FileHelper.GetRootPath() + "/Files/GoodSetting.json";
        [Fact]
        public void ReadSetting_ReadGoodFile()
        {
            AppSetting setting = FileHelper.ReadSetting(goodSettingPath);
            Assert.Equal(setting.overWriteFile, true);
            Assert.Equal(setting.connectionString, "this is a test string");
        }

        [Fact]
        public void ReadSetting2_ReadGoodFile()
        {
            List<Script> scripts = FileHelper.ReadScripts();
            Assert.Equal(scripts[0].contents, "this is text1");
            Assert.Equal(scripts[1].contents, "this is text2");
        }
    }
}
