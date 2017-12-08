using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.BABYTipoUnidad
{
    public partial class frmBABYTipoUnidadCAT : Form
    {
        public frmBABYTipoUnidadCAT()
        {
            InitializeComponent();
        }
        BABYTipoUnidad wf = new BABYTipoUnidad();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            wf.Agregar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            wf.Modificar(0);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            wf.Remover(0);
        }
    }
}
