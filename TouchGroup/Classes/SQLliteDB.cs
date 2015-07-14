using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace TouchGroup
{
    class SQLiteDatabase
    {
        String dbConnection;

        public SQLiteDatabase()
        {
            dbConnection = "Data Source= " + Statics.path_menu_sql;
        }

        public DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            try
            {

                SQLiteConnection cnn = new SQLiteConnection(dbConnection);
                cnn.Open();
                SQLiteCommand mycommand = new SQLiteCommand(cnn);
                mycommand.CommandText = sql;
                SQLiteDataReader reader = mycommand.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                cnn.Close();
            }
            catch (Exception e)
            {

            }
            return dt;
        }

        public int ExecuteNonQuery(string sql)
        {
            SQLiteConnection cnn = new SQLiteConnection(dbConnection);
            cnn.Open();
            SQLiteCommand mycommand = new SQLiteCommand(cnn);
            mycommand.CommandText = sql;

            int rowsUpdated = mycommand.ExecuteNonQuery();
            cnn.Close();
            return rowsUpdated;
        }

        public string ExecuteScalar(string sql)
        {
            SQLiteConnection cnn = new SQLiteConnection(dbConnection);
            cnn.Open();
            SQLiteCommand mycommand = new SQLiteCommand(cnn);
            mycommand.CommandText = sql;
            object value = mycommand.ExecuteScalar();
            cnn.Close();
            if (value != null)
            {
                return value.ToString();
            }
            return "";
        }

        public bool Insert(String tableName, Dictionary<String, Object> data, byte[] image)
        {
            String columns = "";
            String values = "";
            Boolean returnCode = true;
            foreach (KeyValuePair<String, Object> val in data)
            {
                columns += String.Format(" {0},", val.Key.ToString());
                values += String.Format(" '{0}',", val.Value);
            }
            columns = columns.Substring(0, columns.Length - 1);
            values = values.Substring(0, values.Length - 1);
            try
            {
                string cmd = String.Format("insert into {0}({1}) values({2});", tableName, columns, values);
                this.ExecuteNonQueryimg(cmd, image);
            }
            catch (Exception fail)
            {

                returnCode = false;
            }
            return returnCode;
        }
        public int ExecuteNonQueryimg(string sql, byte[] image)
        {
            SQLiteConnection cnn = new SQLiteConnection(dbConnection);
            cnn.Open();
            SQLiteCommand mycommand = new SQLiteCommand(cnn);
            mycommand.CommandText = sql.Replace("'@img'", "@img");

            if (image != null)
            {

                mycommand.Parameters.AddWithValue("@img", image);
            }
            int rowsUpdated = mycommand.ExecuteNonQuery();
            cnn.Close();
            return rowsUpdated;
        }

        public bool Update(String tableName, Dictionary<String, Object> data, String where, byte[] image)
        {
            String vals = "";
            Boolean returnCode = true;
            if (data.Count >= 1)
            {
                foreach (KeyValuePair<String, Object> val in data)
                {
                    vals += String.Format(" {0} = '{1}',", val.Key.ToString(), val.Value.ToString());
                }
                vals = vals.Substring(0, vals.Length - 1);
            }
            try
            {
                this.ExecuteNonQueryimg(String.Format("update {0} set {1} where {2};", tableName, vals, where), image);
            }
            catch
            {
                returnCode = false;
            }
            return returnCode;
        }

        public bool Delete(String tableName, String where)
        {
            Boolean returnCode = true;
            try
            {
                int a = this.ExecuteNonQuery(String.Format("delete from {0} where {1};", tableName, where));
                if (a == 0) return false;
            }
            catch (Exception fail)
            {

                returnCode = false;
            }
            return returnCode;
        }

        public bool DeleteALL(String tableName)
        {
            Boolean returnCode = true;
            try
            {
                int a = this.ExecuteNonQuery(String.Format("delete from {0}", tableName));
                if (a == 0) return false;
            }
            catch (Exception fail)
            {

                returnCode = false;
            }
            return returnCode;
        }

        public bool ClearDB()
        {
            DataTable tables;
            try
            {
                tables = this.GetDataTable("select NAME from SQLITE_MASTER where type='table' order by NAME;");
                foreach (DataRow table in tables.Rows)
                {
                    this.ClearTable(table["NAME"].ToString());
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ClearTable(String table)
        {
            try
            {

                this.ExecuteNonQuery(String.Format("delete from {0};", table));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

}