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
        public static void ExecuteScripts(List<Script> scripts)
        {
            foreach (Script script in scripts)
            {
                try
                {
                    ExecuteScript(script);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(script.name + " : Error. Message : " + ex.Message);
                }
            }
        }

        public static void ExecuteScript(Script script)
        {
            // connect data source
            var connection = new SqlConnection(AppModel.connectionString);
            try
            {
                connection.Open();
                Console.WriteLine(script.name +" : Data surce is connected.");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            // execute sql script
            var command = new SqlCommand(script.contents, connection);
            command.CommandType = CommandType.Text;
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                script.sqlData = reader;
                Console.WriteLine(script.name + " : Sql Script Executed.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
