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


        public static List<string> ExecuteScript(string script, AppSetting setting)
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
            var command = new SqlCommand(script, connection);
            command.CommandType = CommandType.Text;
      
            SqlDataReader reader = command.ExecuteReader();
            string dd =reader.ToString();

            var names = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();
            while (reader.Read())
            {
                var expando = new ExpandoObject() as IDictionary<string, object>;
                for (int i = 0; i < names.Count; i++)
                {
                    expando[names[i]] = reader[names[i]];
                    string ddd = expando[names[i]].ToString();
                    Type type = reader.GetFieldType(i);
                }
            }
            return null;
        }



    }
}
