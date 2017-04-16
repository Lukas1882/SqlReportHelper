using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SqlReportHelper.Models;
using System.Linq;
using System.Collections;
using System.Dynamic;

namespace SqlReportHelper.Common
{
    class DataHelper
    {
        public static void ExecuteScripts(List<Script> scripts, AppSetting setting)
        {
            foreach (Script script in scripts)
            {
                ExecuteScript(script, setting);
            }
        }

        public static void ExecuteScript(Script script, AppSetting setting)
        {
            // connect data source
            var connection = new SqlConnection(setting.connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Data Source is Connected.");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            // execute sql script
            var command = new SqlCommand(script.contents, connection);
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            script.sqlData = reader;// Serialize(reader);
        }
    }
}
