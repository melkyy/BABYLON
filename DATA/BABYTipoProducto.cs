using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class BABYTipoProducto
    {

        public struct DataBABYTipoProducto {

            public int IDTipoProducto;
            public string NombreTipoProducto;
            public string Descripcion;
        }

        public void Agregar(DataBABYTipoProducto Data) {
            Database DB = new Database();
            
            DB.COM.CommandText = "Insert Into BABY.TipoProducto(IDTipoProducto,NombreTipoProducto,Descripcion) values("+Data.IDTipoProducto+",'"+Data.NombreTipoProducto+"','"+Data.Descripcion+"')";
            try
            {
                
            }
            catch {
            
            }

        }

    }
}
