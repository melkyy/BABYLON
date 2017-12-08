using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATA;
namespace GUI.BABYTipoUnidad
{
    public class BABYTipoUnidad
    {
        DATA.BABYTipoUnidad tabla = new DATA.BABYTipoUnidad();
        public void Agregar()
        {
            frmBABYTipoUnidadINS frm = new frmBABYTipoUnidadINS();
            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.OK)
            {
                if(tabla.Agregar(frm.datos) == BABYLON.BABY.enmResultados.OperacionCorrecta)
                {
                    MessageBox.Show("Agregado correctamente", "Agregarinar tipo de unidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error", "Agregar tipo de unidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public DialogResult Modificar(int idTipoUnidad)
        {
            frmBABYTipoUnidadMDF frm = new frmBABYTipoUnidadMDF();
            DATA.BABYTipoUnidad.DataBABYTipoUnidad str = new DATA.BABYTipoUnidad.DataBABYTipoUnidad();
            tabla.Mostrar(ref str, idTipoUnidad);
            frm.id = idTipoUnidad;
            frm.txtNombre.Text = str.NombreTipoUnidad;
            return frm.ShowDialog();
        }
        public void Remover(int idTipoUnidad)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea eliminar el registro?", "Eliminar tipo de unidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if(tabla.Remover(idTipoUnidad) == BABYLON.BABY.enmResultados.OperacionCorrecta)
                {
                    MessageBox.Show("Eliminado correctamente", "Eliminar tipo de unidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error", "Eliminar tipo de unidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }
    }
}
