using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.IO;

namespace WMS
{
    public class SQLiteDatabase
    {
        string DBPath="";
        public SQLiteDatabase(string _DBPath) 
        {
            DBPath = _DBPath;
        }
        public DataTable GetDataTable( string strCMD)
        {
            if (!File.Exists(DBPath)) return null;

            string dbPath = string.Format("Data Source={0}", DBPath);

            try
            {
                SQLiteConnection cnn = new SQLiteConnection(dbPath);
                cnn.Open();
                SQLiteCommand sqlcmd = new SQLiteCommand(cnn);
                sqlcmd.CommandText = strCMD;
                SQLiteDataReader reader = sqlcmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                reader.Close();
                cnn.Close();
                cnn.Dispose();
                return dataTable;
            }
            catch
            {
                //MessageBox.Show("SQLite3 Database Connection Error :" + ex.Message);
                return null;
            }
        }

        public int ExecuteNonQuery( string strCMD)
        {
            if (!File.Exists(DBPath)) return 0;

            string dbPath = string.Format("Data Source={0}", DBPath);
            try
            {
                SQLiteConnection cnn = new SQLiteConnection(dbPath);
                cnn.Open();

                SQLiteCommand sqlcmd = new SQLiteCommand(cnn);
                sqlcmd.CommandText = strCMD;
                int ret = sqlcmd.ExecuteNonQuery();
                cnn.Close();
                cnn.Dispose();
                return ret;
            }
            catch 
            {
                //MessageBox.Show("SQLite3 Database Connection Error :" + ex.Message);
                return 0;
            }
        }


        public bool PingToAddress(string IP)
        {
            try
            {
                Ping PingSender = new Ping();
                int TimeOut = 120;
                string PingData = "TPM";
                byte[] Buffer = System.Text.Encoding.ASCII.GetBytes(PingData);

                PingReply PingReply = PingSender.Send(IP, TimeOut, Buffer);

                if (PingReply.Status == IPStatus.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch { return false; }
        }

        public void _save_sqlite_db(string strPath)
        {
            string dbPath = string.Format("Data Source={0}", strPath);
            DataSet data = null;
            try
            {
                SQLiteConnection cnn = new SQLiteConnection(dbPath);
                cnn.Open();
                SQLiteCommand sqlcmd = new SQLiteCommand(cnn);
                string strSqlCommand = string.Format("select * from tbl_Axis0;");
                sqlcmd.CommandText = strSqlCommand;
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlcmd);
                SQLiteCommandBuilder builder = new SQLiteCommandBuilder(adapter);
                adapter.Update(data.Tables[0]);
                cnn.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("SQLite3 Database Connection Error :" + ex.Message);
            }
        }
    }
}
