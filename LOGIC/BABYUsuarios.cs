using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using DATA;

namespace LOGIC
{
    public class BABYUsuarios
    {

        public bool VerificarUsuario(string Usuario,string Contraseña) {
 
        DATA.BABYUsuarios Tabla = new DATA.BABYUsuarios();
        DATA.BABYUsuarios.DataBABYUsuarios Datos = new DATA.BABYUsuarios.DataBABYUsuarios();
        Datos.Usuario = Usuario;
        Datos.Contraseña = Contraseña;

            if(Tabla.VerificarUsuario(Datos)){
                return true;
            }
            else
            {
                return false;

            }
        }


    }
}
