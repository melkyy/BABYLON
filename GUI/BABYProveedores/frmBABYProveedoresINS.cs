using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.BABYProveedores
{
    public partial class frmBABYProveedoresINS : Form
    {

        public DATA.BABYProveedores.DataBABYProveedores datos = new DATA.BABYProveedores.DataBABYProveedores();


        public frmBABYProveedoresINS()
        {
            InitializeComponent();
        }


        private void Aceptar_Click(object sender, EventArgs e)
        {
            datos.NombreProveedor = txtNombre.Text.Trim();
            datos.Descripcion = txtDescripcion.Text.Trim();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }


    }
}
