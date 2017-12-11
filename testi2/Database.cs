﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testi2
{
    public static class Database
    {
        private static MySqlDataReader reader = null;
        public static MySqlConnection conn = new MySqlConnection("server = mysli.oamk.fi; database = opisk_t6meja00; user id = t6meja00; password = oT5JPmNamE59RWCj;");

        public static void ExecuteQuery(string query)
        {
            try
            {
                // Open the connection
                conn.Open();

            }
            finally
            {
                // Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public static void Execute(string query)
        {
            MySqlCommand cmd = Database.conn.CreateCommand();
            cmd.CommandText = query;
            if (reader != null)
            {
                reader.Close();
                Database.conn.Close();
            }
            try
            {
                Database.conn.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error" + error);
                Database.conn.Close();
            }
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {

            }
            Database.conn.Close();
        }

        public static bool IsEmpty(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);

            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                conn.Close();
                return false;
            }
            else
            { 
                conn.Close();
                return true;
            }

        }

        public static double ListCalc(int index)
        {
            List<double> temp = new List<double>();
            MySqlCommand command = conn.CreateCommand();

            double average = 0;
            double max = 0;
            double min = 0;

            string sql = "SELECT temperature FROM weather";
            command.CommandText = sql;
            conn.Open();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                temp.Add(Convert.ToDouble(reader["temperature"]));
            }
            conn.Close();
            try
            {
                average = temp.Average();
                max = temp.Max();
                min = temp.Min();
            }
            catch (Exception)
            {

            }

            if (index == 0)
            {
                return average;
            }
            else if (index == 1)
            {
                return max;
            }
            else if (index == 2)
            {
                return min;
            }
            else
            {
                return 0;
            }
        }
    }
}