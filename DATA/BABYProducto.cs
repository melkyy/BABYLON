using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using BABYLON;
namespace DATA
{
    public class BABYProducto
    {

        Database DB = new Database();

        public struct DataBABYProducto {
            public int IDProducto;
            public string NombreProducto;
            public int IDTipoProducto;
            public string NombreTipoProducto;


        }
        public BABY.enmResultados Agregar(DataBABYProducto Data)
        {
            DB.COM.CommandText = "Exec BABY.spBABYProducto @NombreProducto,@IDTipoProducto,1";

           
            SqlParameter par1 = new SqlParameter("@NombreProducto", Data.NombreProducto);
            par1.SqlDbType = System.Data.SqlDbType.VarChar;
            SqlParameter par2 = new SqlParameter("@IDTipoProducto", Data.IDTipoProducto);
            par2.SqlDbType = System.Data.SqlDbType.Int;
            

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

        public BABY.enmResultados Modificar(DataBABYProducto Data) {
            DB.COM.CommandText = "Exec BABY.spBABYProducto @NombreProducto,@IDTipoProducto,2";


            SqlParameter par1 = new SqlParameter("@NombreProducto", Data.NombreProducto);
            par1.SqlDbType = System.Data.SqlDbType.VarChar;
            SqlParameter par2 = new SqlParameter("@IDTipoProducto", Data.IDTipoProducto);
            par2.SqlDbType = System.Data.SqlDbType.Int;


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

        public BABY.enmResultados Remover(int IDProducto) {

            DB.COM.CommandText = "Exec BABY.spBABYProducto '',0,3";

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

        public BABY.enmResultados Mostrar(ref DataBABYProducto Data) {
            DB.COM.CommandText = "Select * from BABY.BABYProducto where IDProducto "+Data.IDProducto;

            try
            {
                if (DB.COM.Connection.State == System.Data.ConnectionState.Closed)
                {
                    DB.COM.Connection.Open();
                }

                DB.DR = DB.COM.ExecuteReader();
                if (DB.DR.Read())
                {
                    Data.IDTipoProducto = (int)DB.DR["IDTipoProducto"];
                    Data.NombreTipoProducto = (string)DB.DR["NombreTipoProducto"];
                    Data.IDProducto = (int)DB.DR["IDProducto"];
                    Data.NombreProducto = (string)DB.DR["NombreProducto"];



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

        public BABY.enmResultados Listar(ref DataBABYProducto[] Data,string Filtro) {

            DB.COM.CommandText = "Select COUNT(*) from BABY.BABYProducto where NombreProducto " + Filtro;
            if (DB.COM.Connection.State == System.Data.ConnectionState.Closed)
            {
                DB.COM.Connection.Open();
            }
            int Cuantos = (int)DB.COM.ExecuteScalar();
            DB.COM.CommandText = "Select * from BABY.BABYProducto where NombreProducto " + Filtro;

            try
            {
                if (DB.COM.Connection.State == System.Data.ConnectionState.Closed)
                {
                    DB.COM.Connection.Open();
                }

                DB.DR = DB.COM.ExecuteReader();
                int i = 0;
                Data= new DataBABYProducto[Cuantos];
                while(DB.DR.Read())
                {
                    Data[i].IDTipoProducto = (int)DB.DR["IDTipoProducto"];
                    Data[i].NombreTipoProducto = (string)DB.DR["NombreTipoProducto"];
                    Data[i].IDProducto = (int)DB.DR["IDProducto"];
                    Data[i].NombreProducto = (string)DB.DR["NombreProducto"];

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
