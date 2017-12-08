using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOGIC;
namespace GUI.BABYTipoProducto
{
    public partial class frmBABYTipoProductoCAT : Form
    {
        public frmBABYTipoProductoCAT()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            BABYTipoProducto Formas = new BABYTipoProducto();

            Formas.frmINS();
            RefreshList();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            BABYTipoProducto Formas = new BABYTipoProducto();

            
            Formas.frmMDF();
            RefreshList();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(Lista.SelectedItems.Count==1){
            int id = ((DATA.BABYTipoProducto.DataBABYTipoProducto)Lista.SelectedItems[0].Tag).IDTipoProducto;
            LOGIC.BABYTipoProducto Tabla = new LOGIC.BABYTipoProducto();
            Tabla.Remover(id);
            RefreshList();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtTipoProducto_TextChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void frmBABYTipoProductoCAT_Load(object sender, EventArgs e)
        {
            RefreshList();
        }
        public void RefreshList() {
            DATA.BABYTipoProducto.DataBABYTipoProducto str = new DATA.BABYTipoProducto.DataBABYTipoProducto();
            LOGIC.BABYTipoProducto TABLA = new LOGIC.BABYTipoProducto();
            DATA.BABYTipoProducto.DataBABYTipoProducto[] ARR = null;
            str.NombreTipoProducto = TxtTipoProducto.Text;

            ARR = TABLA.Listar(str.NombreTipoProducto);

            Lista.Items.Clear();
            ListViewItem L;
            foreach(DATA.BABYTipoProducto.DataBABYTipoProducto Datos in ARR){
                L = new ListViewItem();
                L.Tag = Datos;
                L.Text=Datos.IDTipoProducto.ToString();
                L.SubItems.Add(Datos.NombreTipoProducto);
                L.SubItems.Add(Datos.Descripcion);

                Lista.Items.Add(L);
            }
            
            
        
        }
    }
}
