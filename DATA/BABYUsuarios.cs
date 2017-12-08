using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class BABYUsuarios
    {
        Database DB = new Database();
        public struct DataBABYUsuarios {

            public string Usuario;
            public string Contraseña;
        
        }

        public bool VerificarUsuario(DataBABYUsuarios Data) {
            DB.COM.CommandText = "exec BABY.spBABYVerificarUsuario "+Data.Usuario+","+Data.Contraseña;

            try
            {
                DB.COM.Connection=DB.getConnection();
                DB.COM.Connection.Open();
                DB.DR = DB.COM.ExecuteReader();
                if(DB.DR.Read()){

                    return true;
                    DB.DR.Close();
                }
                else
                {
                    return false;
                    DB.DR.Close();
                }

            }
            catch {
                return false;
                DB.DR.Close();
            }
        
        }
    }
}
