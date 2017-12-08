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
            string cmdText = "BABY.spBABYProveedoresINS";
            SqlCommand cmd = new SqlCommand(cmdText, DB.getConnection());
            SqlParameter par1 = new SqlParameter("@NombreProveedor", str.NombreProveedor);
            par1.SqlDbType = System.Data.SqlDbType.VarChar;
            SqlParameter par2 = new SqlParameter("@Descripcion", str.Descripcion);
            par2.SqlDbType = System.Data.SqlDbType.Text;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
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
            string cmdText = "BABY.spBABYProveedoresMDF";
            SqlCommand cmd = new SqlCommand(cmdText, DB.getConnection());
            SqlParameter par1 = new SqlParameter("@NombreProveedor", str.NombreProveedor);
            par1.SqlDbType = System.Data.SqlDbType.VarChar;
            SqlParameter par2 = new SqlParameter("@Descripcion", str.Descripcion);
            par2.SqlDbType = System.Data.SqlDbType.Text;
            SqlParameter par3 = new SqlParameter("@idProveedor", str.idProveedor);
            par3.SqlDbType = System.Data.SqlDbType.Int;
            cmd.Parameters.Add(par1);
            cmd.Parameters.Add(par2);
            cmd.Parameters.Add(par3);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
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
            string cmdText = "BABY.spBABYProveedoresRMV";
            SqlCommand cmd = new SqlCommand(cmdText, DB.getConnection());
            SqlParameter par1 = new SqlParameter("@idProveedor", idProveedor);
            par1.SqlDbType = System.Data.SqlDbType.Int;
            cmd.Parameters.Add(par1);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
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
                    ARR[i].idProveedor = Convert.ToInt32(dr["idProveedor"]);
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
