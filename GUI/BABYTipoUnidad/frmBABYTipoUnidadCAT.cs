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
            Refreshlist(txtTipoUnidad.Text);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = ((DATA.BABYTipoUnidad.DataBABYTipoUnidad)lstLista.SelectedItems[0].Tag).idTipoUnidad;
                wf.Modificar(id);
                Refreshlist(txtTipoUnidad.Text);
            }
            catch { }
            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                int id = ((DATA.BABYTipoUnidad.DataBABYTipoUnidad)lstLista.SelectedItems[0].Tag).idTipoUnidad;
                wf.Remover(id);
                Refreshlist(txtTipoUnidad.Text);
            }
            catch { }
        }

        public void Refreshlist(string filtro)
        {
            lstLista.Items.Clear();
            DATA.BABYTipoUnidad.DataBABYTipoUnidad[] arr = null;
            DATA.BABYTipoUnidad tabla = new DATA.BABYTipoUnidad();
            tabla.Listar(ref arr, filtro);
            foreach(DATA.BABYTipoUnidad.DataBABYTipoUnidad s in arr)
            {
                ListViewItem i = new ListViewItem();
                i.Text = s.NombreTipoUnidad;
                i.Tag = s;
                lstLista.Items.Add(i);
            }
        }

        private void frmBABYTipoUnidadCAT_Load(object sender, EventArgs e)
        {
            Refreshlist("");
        }

        private void txtTipoUnidad_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Refreshlist(txtTipoUnidad.Text);
            }
        }
    }
}
