using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BABYLON;
using System.Data.SqlClient;
namespace DATA
{
    public class BABYProveedores
    {
        Database DB = new Database();
        public struct DataBABYProveedores
        {
            public int idProveedor;
            public string NombreProveedor;
            public string Descripcion;
        }
        public BABY.enmResultados Agregar(DataBABYProveedores str)
        {
            string cmdText = "INSERT INTO [BABY].[Proveedores] (NombreProveedor, Descripcion) values (@NombreProveedor, @Descripcion)";
            SqlCommand cmd = new SqlCommand(cmdText, DB.getConnection());
            SqlParameter par1 = new SqlParameter("@NombreProveedor", str.NombreProveedor);
            par1.SqlDbType = System.Data.SqlDbType.VarChar;
            SqlParameter par2 = new SqlParameter("@Descripcion", str.Descripcion);
            par1.SqlDbType = System.Data.SqlDbType.Text;
            cmd.Parameters.Add(par1);
            cmd.Parameters.Add(par2);
            try
            {
                if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return BABY.enmResultados.OperacionCorrecta;
            }
            catch
            {
                return BABY.enmResultados.ErrorDeConexion;
            }
        }
        public BABY.enmResultados Modificar(DataBABYProveedores str)
        {
            string cmdText = "UPDATE [BABY].[Proveedores] SET NombreProveedor = @NombreProveedor, Descripcion = @Descripcion WHERE idProveedor = " + str.idProveedor;
            SqlCommand cmd = new SqlCommand(cmdText, DB.getConnection());
            SqlParameter par1 = new SqlParameter("@NombreProveedor", str.NombreProveedor);
            par1.SqlDbType = System.Data.SqlDbType.VarChar;
            SqlParameter par2 = new SqlParameter("@Descripcion", str.Descripcion);
            par1.SqlDbType = System.Data.SqlDbType.Text;
            cmd.Parameters.Add(par1);
            cmd.Parameters.Add(par2);

            try
            {
                if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return BABY.enmResultados.OperacionCorrecta;
            }
            catch
            {
                return BABY.enmResultados.ErrorDeConexion;
            }
        }
        public BABY.enmResultados Remover(int idProveedor)
        {
            string cmdText = "DELETE FROM [BABY].[Proveedores] WHERE idProveedor = " + idProveedor;
            SqlCommand cmd = new SqlCommand(cmdText, DB.getConnection());
            try
            {
                if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return BABY.enmResultados.OperacionCorrecta;
            }
            catch
            {
                return BABY.enmResultados.ErrorDeConexion;
            }
        }
        public BABY.enmResultados Mostrar(ref DataBABYProveedores str, int idProveedor)
        {
            string cmdText = "SELECT * FROM [BABY].[Proveedores] WHERE idProveedor = " + idProveedor;
            SqlCommand cmd = new SqlCommand(cmdText, DB.getConnection());
            try
            {
                if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }

                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                str.NombreProveedor = Convert.ToString(dr["NombreProveedor"]);
                str.Descripcion = Convert.ToString(dr["Descripcion"]);
                dr.Close();
                cmd.Connection.Close();
                return BABY.enmResultados.OperacionCorrecta;
            }
            catch
            {
                return BABY.enmResultados.ErrorDeConexion;
            }
        }
        public BABY.enmResultados Listar(ref DataBABYProveedores[] ARR, string Filtro)
        {
            string cmdText = "SELECT COUNT(*) AS Cant FROM [BABY].[Proveedores] WHERE NombreProveedor LIKE '%" + Filtro + "%'";
            SqlCommand cmd = new SqlCommand(cmdText, DB.getConnection());
            try
            {
                if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                int c = Convert.ToInt32(cmd.ExecuteScalar());
                cmdText = "SELECT * FROM [BABY].[Proveedores] WHERE NombreProveedor LIKE '%" + Filtro + "%'";
                cmd.CommandText = cmdText;
                SqlDataReader dr = cmd.ExecuteReader();
                int i = 0;
                ARR = new DataBABYProveedores[c];
                while (dr.Read())
                {
                    ARR[i].Descripcion = Convert.ToString(dr["Descripcion"]);
                    ARR[i].NombreProveedor = Convert.ToString(dr["NombreProveedor"]);
                    i++;
                }
                dr.Close();
                cmd.Connection.Close();
                return BABY.enmResultados.OperacionCorrecta;
            }
            catch
            {
                return BABY.enmResultados.ErrorDeConexion;
            }
        }
    }
}
