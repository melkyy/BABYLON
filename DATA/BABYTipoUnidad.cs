using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BABYLON;
namespace DATA
{
    public class BABYTipoUnidad
    {

        Database DB = new Database();
        public struct DataBABYTipoUnidad
        {
            public int idTipoUnidad;
            public string NombreTipoUnidad;
        }

        public BABY.enmResultados Agregar(DataBABYTipoUnidad str)
        {
            string cmdText = "BABY.spBABYTipoUnidadINS";
            SqlCommand cmd = new SqlCommand(cmdText, DB.getConnection());
            SqlParameter par1 = new SqlParameter("@NombreTipoUnidad", str.NombreTipoUnidad);
            par1.SqlDbType = System.Data.SqlDbType.VarChar;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(par1);
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
        public BABY.enmResultados Modificar(DataBABYTipoUnidad str)
        {
            string cmdText = "UPDATE [BABY].[TipoUnidad] SET NombreTipoUnidad = @NombreTipoUnidad WHERE idTipoUnidad = " + str.idTipoUnidad;
            SqlCommand cmd = new SqlCommand(cmdText, DB.getConnection());
            SqlParameter par1 = new SqlParameter("@NombreTipoUnidad", str.NombreTipoUnidad);
            par1.SqlDbType = System.Data.SqlDbType.VarChar;
            cmd.Parameters.Add(par1);
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
        public BABY.enmResultados Remover(int idTipoUnidad)
        {
            string cmdText = "DELETE FROM [BABY].[TipoUnidad] WHERE idTipoUnidad = " + idTipoUnidad;
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
        public BABY.enmResultados Mostrar(ref DataBABYTipoUnidad str, int idTipoUnidad)
        {
            string cmdText = "SELECT * FROM [BABY].[TipoUnidad] WHERE idTipoUnidad = " + idTipoUnidad;
            SqlCommand cmd = new SqlCommand(cmdText, DB.getConnection());
            try
            {
                if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }

                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                str.idTipoUnidad = Convert.ToInt32(dr["idTipoUnidad"]);
                str.NombreTipoUnidad = Convert.ToString(dr["NombreTipoUnidad"]);
                dr.Close();
                cmd.Connection.Close();
                return BABY.enmResultados.OperacionCorrecta;
            }
            catch
            {
                return BABY.enmResultados.ErrorDeConexion;
            }
        }
        public BABY.enmResultados Listar(ref DataBABYTipoUnidad[] ARR, string Filtro)
        {
            string cmdText = "SELECT COUNT(*) AS Cant FROM [BABY].[TipoUnidad] WHERE NombreTipoUnidad LIKE '%" + Filtro + "%'";
            SqlCommand cmd = new SqlCommand(cmdText, DB.getConnection());
            try
            {
                if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                int c = Convert.ToInt32(cmd.ExecuteScalar());
                cmdText = "SELECT * FROM [BABY].[TipoUnidad] WHERE NombreTipoUnidad LIKE '%" + Filtro + "%'";
                cmd.CommandText = cmdText;
                SqlDataReader dr = cmd.ExecuteReader();
                int i = 0;
                ARR = new DataBABYTipoUnidad[c];
                while (dr.Read())
                {
                    ARR[i].idTipoUnidad = Convert.ToInt32(dr["idTipoUnidad"]);
                    ARR[i].NombreTipoUnidad = Convert.ToString(dr["NombreTipoUnidad"]);
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
