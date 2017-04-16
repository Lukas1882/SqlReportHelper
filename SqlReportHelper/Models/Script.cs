using System;
using System.Collections.Generic;
using System.Text;

namespace SqlReportHelper.Models
{
    class Script
    {
        public Script(string name, string contents)
        {
            this.name = name;
            this.contents = contents;
        }

        public string  name { get; set; }
        public string  contents { get; set; }
    }
}
