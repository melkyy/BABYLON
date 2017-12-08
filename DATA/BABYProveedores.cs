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
        public struct BABYProveedores
        {
            public int idProveedor;
            public string NombreProveedor;
            public int idProducto;
        }
        public BABY.enmResultados Agregar(BABYProveedores str)
        {
            string cmdText = "INSERT INTO [BABY].[Proveedores] (NombreProveedor, idProducto) values (@NombreProveedor, @idProducto)";
            SqlCommand cmd = new SqlCommand(cmdText, DB.getConnection());
            SqlParameter par1 = new SqlParameter("@NombreProveedor", str.NombreProveedor);
            par1.SqlDbType = System.Data.SqlDbType.VarChar;
            SqlParameter par2 = new SqlParameter("@idProducto", str.idProducto);
            par1.SqlDbType = System.Data.SqlDbType.Int;
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
        public BABY.enmResultados Modificar(BABYProveedores str)
        {
            string cmdText = "UPDATE [BABY].[Proveedores] SET NombreProveedor = @NombreProveedor, idProducto = @idProducto WHERE idProducto = " + str.idProducto;
            SqlCommand cmd = new SqlCommand(cmdText, DB.getConnection());
            SqlParameter par1 = new SqlParameter("@NombreProveedor", str.NombreProveedor);
            par1.SqlDbType = System.Data.SqlDbType.VarChar;
            SqlParameter par2 = new SqlParameter("@idProducto", str.idProducto);
            par1.SqlDbType = System.Data.SqlDbType.Int;
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
        public BABY.enmResultados Remover(int idProducto)
        {
            string cmdText = "DELETE FROM [BABY].[Proveedores] WHERE idProducto = " + idProducto;
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
        public BABY.enmResultados Mostrar(ref BABYProveedores str, int idProducto)
        {
            string cmdText = "SELECT * FROM [BABY].[Proveedores] WHERE idProducto = " + idProducto;
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
                str.idProducto = Convert.ToInt32(dr["idProducto"]);
                dr.Close();
                cmd.Connection.Close();
                return BABY.enmResultados.OperacionCorrecta;
            }
            catch
            {
                return BABY.enmResultados.ErrorDeConexion;
            }
        }
        public BABY.enmResultados Listar(ref BABYProveedores[] ARR, string Filtro)
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
                SqlDataReader dr = cmd.ExecuteReader();
                int i = 0;
                ARR = new BABYProveedores[c];
                while (dr.Read())
                {
                    ARR[i].idProducto = Convert.ToInt32(dr["idProducto"]);
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
