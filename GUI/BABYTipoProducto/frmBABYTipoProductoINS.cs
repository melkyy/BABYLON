using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.BABYTipoProducto
{
    public partial class frmBABYTipoProductoINS : Form
    {
        public frmBABYTipoProductoINS()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGIC.BABYTipoProducto Tabla = new LOGIC.BABYTipoProducto();
            Tabla.Agregar(TxtNombreTipoProducto.Text, TxtDescripcion.Text);
            Close();
            
        }
    }
}
