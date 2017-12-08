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
    public partial class frmBABYProveedoresCAT : Form
    {
        public frmBABYProveedoresCAT()
        {
            InitializeComponent();
        }

        BABYProveedores wf = new BABYProveedores();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            wf.Agregar();
            Refreshlist(txtProveedor.Text);
        }
        public void Refreshlist(string filtro)
        {
            lstLista.Items.Clear();
            DATA.BABYProveedores.DataBABYProveedores[] arr = null;
            DATA.BABYProveedores tabla = new DATA.BABYProveedores();
            tabla.Listar(ref arr, filtro);
            foreach (DATA.BABYProveedores.DataBABYProveedores s in arr)
            {
                ListViewItem i = new ListViewItem();
                i.Text = s.NombreProveedor;
                i.SubItems.Add(s.Descripcion);
                i.Tag = s;
                lstLista.Items.Add(i);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = ((DATA.BABYProveedores.DataBABYProveedores)lstLista.SelectedItems[0].Tag).idProveedor;
                wf.Modificar(id);
                Refreshlist(txtProveedor.Text);
            }
            catch { }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                int id = ((DATA.BABYProveedores.DataBABYProveedores)lstLista.SelectedItems[0].Tag).idProveedor;
                wf.Remover(id);
                Refreshlist(txtProveedor.Text);
            }
            catch { }
        }

        private void frmBABYProveedoresCAT_Load(object sender, EventArgs e)
        {
            Refreshlist("");
        }

        private void txtProveedor_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Refreshlist(txtProveedor.Text);

            }
        }

    }
}
