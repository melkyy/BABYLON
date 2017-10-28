using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
namespace DATA
{
    public class Database
    {
        private SqlConnection Connection;

        public Database()
        {
            try
            {
                Connection = new SqlConnection(ReadConnectionString());
            }
            catch
            {

            }
        }
        public SqlConnection getConnection()
        {
            if (Connection == null)
            {
                Connection = new SqlConnection(ReadConnectionString());
            }
            return Connection;
        }
        private void readConfig()
        {
            //aquí leer archivo con la configuracion
        }

        private static string dbfile = Environment.CurrentDirectory + "\\db.conf";

        public static string ReadConnectionString()
        {
            string s = string.Empty;
            try
            {
                if (!File.Exists(dbfile))
                    File.WriteAllText(dbfile, "");
                s = File.ReadAllText(dbfile);
            }
            catch { }
            return s;
        }
        public static void WriteConnectionString(string Conn)
        {
            try
            {
                File.WriteAllText(dbfile, Conn);
            }
            catch { }
        }
    }
}
