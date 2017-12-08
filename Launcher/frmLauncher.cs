using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI;
using DATA;
namespace Launcher
{
    public partial class frmLauncher : Form
    {
        public frmLauncher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI.DBConfig.frmDBConfig frm = new GUI.DBConfig.frmDBConfig();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Database DB = new Database();
            
            BABYTipoProducto Tabla = new BABYTipoProducto();
            BABYTipoProducto.DataBABYTipoProducto s= new BABYTipoProducto.DataBABYTipoProducto();
            s.IDTipoProducto = 1;
            s.NombreTipoProducto = "Melky";
            s.Descripcion = "asdasd";
            Tabla.Agregar(s);
        }
    }
}
