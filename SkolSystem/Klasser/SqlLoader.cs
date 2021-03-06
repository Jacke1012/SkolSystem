﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolSystem.Klasser
{
    public class SqlLoader
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|SkolSystem.mdf; Integrated Security=True";
        public static void SendQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<object[]> Fetch(string query)
        {
            List<object[]> temp = new List<object[]>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            object[] tempObj = new object[reader.FieldCount];
                            for (int i = 0; i < tempObj.Length ; i++)
                            {
                                tempObj[i] = reader.GetValue(i);
                            }
                            temp.Add(tempObj);
                        }
                    }
                }
            }
            return temp;
        }
    }
}
