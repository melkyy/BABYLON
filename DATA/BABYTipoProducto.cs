using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BABYLON;
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace DATA
{
    public class BABYTipoProducto
    {

        public struct DataBABYTipoProducto {

            public int IDTipoProducto;
            public string NombreTipoProducto;
            public string Descripcion;
        }

        public BABY.enmResultados Agregar(DataBABYTipoProducto Data) {
            Database DB = new Database();
            
            DB.COM.CommandText = "Exec BABY.spBABYTipoProducto @NombreTipoProducto,@Descripcion,0,1";
            SqlParameter par1 = new SqlParameter("@NombreTipoProducto",Data.NombreTipoProducto);
            par1.SqlDbType =  System.Data.SqlDbType.VarChar;
            SqlParameter par2 = new SqlParameter("@Descripcion",Data.Descripcion);
            par2.SqlDbType = System.Data.SqlDbType.Text;

            DB.COM.Parameters.Add(par1);
            DB.COM.Parameters.Add(par2);


            try
            {
                if (DB.COM.Connection.State == System.Data.ConnectionState.Closed)
                {
                    DB.COM.Connection.Open();
                }
                DB.COM.ExecuteNonQuery();
                DB.COM.Connection.Close();
                return BABY.enmResultados.OperacionCorrecta;
            }
            catch
            {
                return BABY.enmResultados.ErrorDeConexion;
            }

        }

        public BABY.enmResultados Modifcar(DataBABYTipoProducto Data) {
            Database DB = new Database();

            DB.COM.CommandText = "Exec BABY.spBABYTipoProducto @NombreTipoProducto,@Descripcion,@IDTipoProducto,2";
            SqlParameter par1 = new SqlParameter("@NombreTipoProducto", Data.NombreTipoProducto);
            par1.SqlDbType = System.Data.SqlDbType.VarChar;
            SqlParameter par2 = new SqlParameter("@Descripcion", Data.Descripcion);
            par2.SqlDbType = System.Data.SqlDbType.Text;
            SqlParameter par3 = new SqlParameter("@IDTipoProducto",Data.IDTipoProducto);
            par3.SqlDbType = System.Data.SqlDbType.Int;

            DB.COM.Parameters.Add(par1);
            DB.COM.Parameters.Add(par2);
            DB.COM.Parameters.Add(par3);


            try
            {
                if (DB.COM.Connection.State == System.Data.ConnectionState.Closed)
                {
                    DB.COM.Connection.Open();
                }
                DB.COM.ExecuteNonQuery();
                DB.COM.Connection.Close();
                return BABY.enmResultados.OperacionCorrecta;
            }
            catch
            {
                return BABY.enmResultados.ErrorDeConexion;
            }

        }


        public BABY.enmResultados Remover(int IDTipoProducto) {

            Database DB = new Database();

            DB.COM.CommandText = "Exec BABY.spBABYTipoProducto '','',@IDTipoProducto,3";
            
            SqlParameter par1 = new SqlParameter("@IDTipoProducto", IDTipoProducto);
            par1.SqlDbType = System.Data.SqlDbType.Int;

            DB.COM.Parameters.Add(par1);
           


            try
            {
                if (DB.COM.Connection.State == System.Data.ConnectionState.Closed)
                {
                    DB.COM.Connection.Open();
                }
                DB.COM.ExecuteNonQuery();
                DB.COM.Connection.Close();
                return BABY.enmResultados.OperacionCorrecta;
            }
            catch
            {
                return BABY.enmResultados.ErrorDeConexion;
            }


        }

        public BABY.enmResultados Mostrar(ref DataBABYTipoProducto Data) {

            Database DB = new Database();

            DB.COM.CommandText = "Select * from BABY.BABYTipoProducto where IDTipoProducto = "+Data.IDTipoProducto;

            try
            {
                if (DB.COM.Connection.State == System.Data.ConnectionState.Closed)
                {
                    DB.COM.Connection.Open();
                }

                DB.DR = DB.COM.ExecuteReader();
                if (DB.DR.Read()) {
                    Data.IDTipoProducto = (int)DB.DR["IDTipoProducto"];
                    Data.NombreTipoProducto = (string)DB.DR["NombreTipoProducto"];
                    Data.Descripcion = (string)DB.DR["Descripcion"];



                }
                DB.DR.Close();
                DB.COM.Connection.Close();
                return BABY.enmResultados.OperacionCorrecta;
               
            }
            catch {
                return BABY.enmResultados.ErrorDeBaseDeDatos;
            }

            
        }

        public BABY.enmResultados Listar(ref DataBABYTipoProducto[] Data,String Filtro) {
            Database DB = new Database();

            DB.COM.CommandText = "Select Count(*) from BABY.BABYTipoProducto where NombreTipoProducto like '%" + Filtro + "%'";
            if (DB.COM.Connection.State == System.Data.ConnectionState.Closed)
            {
                DB.COM.Connection.Open();
            }
            int Cuanto = (int)DB.COM.ExecuteScalar();

            DB.COM.CommandText = "Select * from BABY.BABYTipoProducto where NombreTipoProducto like '%"+Filtro+"%'";
            
            

            try
            {
                if (DB.COM.Connection.State == System.Data.ConnectionState.Closed)
                {
                    DB.COM.Connection.Open();
                }

                DB.DR = DB.COM.ExecuteReader();
                int i = 0;
                Data = new DataBABYTipoProducto[Cuanto];
                while(DB.DR.Read())
                {
                    Data[i].IDTipoProducto = (int)DB.DR["IDTipoProducto"];
                    Data[i].NombreTipoProducto = (string)DB.DR["NombreTipoProducto"];
                    Data[i].Descripcion = (string)DB.DR["Descripcion"];

                    i++;

                }
                DB.DR.Close();
                DB.COM.Connection.Close();
                return BABY.enmResultados.OperacionCorrecta;

            }
            catch
            {
                return BABY.enmResultados.ErrorDeBaseDeDatos;
            }


        }
    }
}
