using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.BABYProveedores
{
    public class BABYProveedores
    {

        DATA.BABYProveedores tabla = new DATA.BABYProveedores();
        public void Agregar()
        {
            frmBABYProveedoresINS frm = new frmBABYProveedoresINS();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                if (tabla.Agregar(frm.datos) == BABYLON.BABY.enmResultados.OperacionCorrecta)
                {
                    MessageBox.Show("Agregado correctamente", "Agregarinar proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error", "Agregar proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public DialogResult Modificar(int idTipoUnidad)
        {
            frmBABYProveedoresMDF frm = new frmBABYProveedoresMDF();
            DATA.BABYProveedores.DataBABYProveedores str = new DATA.BABYProveedores.DataBABYProveedores();
            tabla.Mostrar(ref str, idTipoUnidad);
            frm.id = idTipoUnidad;
            frm.txtNombre.Text = str.NombreProveedor;
            frm.txtDescripcion.Text = str.Descripcion;
            return frm.ShowDialog();
        }
        public void Remover(int idProveedor)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea eliminar el registro?", "Eliminar tipo de unidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (tabla.Remover(idProveedor) == BABYLON.BABY.enmResultados.OperacionCorrecta)
                {
                    MessageBox.Show("Eliminado correctamente", "Eliminar proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error", "Eliminar proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

    }
}
