using System;
using System.Collections.Generic;
using System.Text;

namespace SqlReportHelper.Models
{
    class Setting
    {
        public string connectionString { get; set; }
        public bool overWriteFile { get; set; }
        public bool addNewSheet { get; set; }
    }
}
