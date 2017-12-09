using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using System.Windows.Forms;
namespace LOGIC
{
    public class BABYTipoProducto
    {
        public DATA.BABYTipoProducto.DataBABYTipoProducto[] Listar (string Filtro)
        {
            DATA.BABYTipoProducto Tabla = new DATA.BABYTipoProducto();
            DATA.BABYTipoProducto.DataBABYTipoProducto[] Data = null;

            if(Tabla.Listar(ref Data,Filtro)==BABYLON.BABY.enmResultados.OperacionCorrecta){
                
                return Data;
            }
            else
            {

                return null;
            }
        
        }

        public void Agregar(string NombreTipoProducto,string Descripcion) {

            DATA.BABYTipoProducto Tabla = new DATA.BABYTipoProducto();
            DATA.BABYTipoProducto.DataBABYTipoProducto Datos = new DATA.BABYTipoProducto.DataBABYTipoProducto();
            Datos.NombreTipoProducto=NombreTipoProducto;
            Datos.Descripcion=Descripcion;

            if (Tabla.Agregar(Datos) == BABYLON.BABY.enmResultados.OperacionCorrecta)
            {

                MessageBox.Show("Se ha agregado Correctamente");
            }
            else {
                MessageBox.Show("ha Ocurrido un error");
            }
        
        }

        public void Modificar(string NombreTipoProducto, string Descripcion,int IDTipoProducto)
        {
            DATA.BABYTipoProducto Tabla = new DATA.BABYTipoProducto();
            DATA.BABYTipoProducto.DataBABYTipoProducto Datos = new DATA.BABYTipoProducto.DataBABYTipoProducto();
            Datos.NombreTipoProducto = NombreTipoProducto;
            Datos.Descripcion = Descripcion;
            Datos.IDTipoProducto = IDTipoProducto;

            if (Tabla.Modifcar(Datos) == BABYLON.BABY.enmResultados.OperacionCorrecta)
            {

                MessageBox.Show("Se ha agregado Correctamente");
            }
            else
            {
                MessageBox.Show("ha Ocurrido un error");
            }
        
        }

        public DATA.BABYTipoProducto.DataBABYTipoProducto Mostrar(int id) {
            DATA.BABYTipoProducto Tabla = new DATA.BABYTipoProducto();
            DATA.BABYTipoProducto.DataBABYTipoProducto Datos = new DATA.BABYTipoProducto.DataBABYTipoProducto();

            if (Tabla.Mostrar(ref Datos) == BABYLON.BABY.enmResultados.OperacionCorrecta)
            {

                return Datos;
            }
            else
            {

                MessageBox.Show("ha Ocurrido un error");
            }
            return Datos;
        }

        public void Remover(int id) {

            DATA.BABYTipoProducto Tabla = new DATA.BABYTipoProducto();
           

            if(Tabla.Remover(id)==BABYLON.BABY.enmResultados.OperacionCorrecta){

                MessageBox.Show("Se ha Removido Correctamente");
            }else{

                MessageBox.Show("ha Ocurrido un error");
            }
        
        }
    }
}
