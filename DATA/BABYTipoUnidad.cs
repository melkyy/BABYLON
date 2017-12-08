using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class BABYTipoUnidad
    {
        Database DB = new Database();
        public struct DataBABYTipoUnidad {
            public int IDTipoUnidad;
            public string NombreTipoUnidad;
            
        }

        public void Listar(ref DataBABYTipoUnidad Dato,ref bool error) {
            DB.COM.CommandText = "Select * from BABY.BABYTipoUnidad where NombreTipoUnidad like '%"+Dato.NombreTipoUnidad+"%'";
            try
            {
                DB.COM.Connection = DB.getConnection();
                DB.DR = DB.COM.ExecuteReader();
                while (DB.DR.Read()) {
                    Dato.NombreTipoUnidad = DB.DR["NombreTipoUnidad"].ToString();
                }
                error = true;
            }
            catch {

                error = false;
            }

        }

        public bool Agregar(DataBABYTipoUnidad Dato) {
            DB.COM.CommandText = "exec spBABYTipoUnidad '"+Dato.NombreTipoUnidad+"'";

            try
            {
                DB.COM.Connection = DB.getConnection();
                DB.COM.Connection.Open();
                DB.COM.ExecuteNonQuery();
                return true;
            }
            catch {
                return false;
            }

        }

        public bool Modificar(DataBABYTipoUnidad Dato) {
            DB.COM.CommandText = "EXEC spBABYTipoUnidad '"+Dato.NombreTipoUnidad+"',"+Dato.IDTipoUnidad+"";
            try
            {
                DB.COM.Connection = DB.getConnection();
                DB.COM.Connection.Open();
                DB.COM.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }


        }

        public bool Remover(int IDTipoUnidad) {
            DB.COM.CommandText = "EXEC spBABYTipoUnidad " + IDTipoUnidad;
            try
            {
                DB.COM.Connection = DB.getConnection();
                DB.COM.Connection.Open();
                DB.COM.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
