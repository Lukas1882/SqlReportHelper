using System;
using System.Collections.Generic;
using System.Text;

namespace SqlReportHelper.Models
{
    class AppSetting
    {
        public  string connectionString { get; set; }
        public  bool overWriteFile { get; set; }
        public  bool addNewSheet { get; set; }
        //public List<OutputMapping> outputMappings{ get; set; }
}

    //class OutputMapping
    //{
    //    public string scriptName { get; set; }
    //    public string outputName { get; set; }
    //}
}
