using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DATA
{
    public class Database
    {
        private string ConnectionString = string.Empty;
        public SqlConnection Connection { get; private set; }
        public Database()
        {

        }
        public Database();
        public SqlConnection getConnection()
        {
            if (Connection == null)
            {
                Connection = new SqlConnection(ConnectionString);
            }
            return Connection;
        }
        private void readConfig()
        {
            //aquí leer archivo con la configuracion
        }
    }
}
