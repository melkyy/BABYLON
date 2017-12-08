using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BABYLON;
namespace GUI.BABYProveedores
{
    public partial class frmBABYProveedoresMDF : Form
    {
        public int id;
        public frmBABYProveedoresMDF()
        {
            InitializeComponent();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            DATA.BABYProveedores tabla = new DATA.BABYProveedores();
            DATA.BABYProveedores.DataBABYProveedores str = new DATA.BABYProveedores.DataBABYProveedores();
            str.idProveedor = id;
            str.NombreProveedor = txtNombre.Text.Trim();
            str.Descripcion = txtDescripcion.Text.Trim();
            if (tabla.Modificar(str) == BABY.enmResultados.OperacionCorrecta)
            {
                MessageBox.Show(this, "Editado correctamente", "Operación correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show(this, "Ha ocurrido un error", "Operación erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            }
        }
    }
}
