using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Interface_BABYLON
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void MENU_Load(object sender, EventArgs e)
        {
            LOGIN Forma = new LOGIN();
            DialogResult Resultado;
            Resultado = Forma.ShowDialog(this);


            this.Focus();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tipoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BABYTipoProducto.frmBABYTipoProductoCAT Forma = new BABYTipoProducto.frmBABYTipoProductoCAT();
            Forma.ShowDialog();
        }

        private void tipoDeUnidadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void capturaDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
