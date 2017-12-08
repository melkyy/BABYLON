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

namespace GUI.BABYTipoUnidad
{
    public partial class frmBABYTipoUnidadINS : Form
    {
        public frmBABYTipoUnidadINS()
        {
            InitializeComponent();
        }
        public DATA.BABYTipoUnidad.DataBABYTipoUnidad datos = new DATA.BABYTipoUnidad.DataBABYTipoUnidad();
        private void Aceptar_Click(object sender, EventArgs e)
        {
            datos.NombreTipoUnidad = txtNombre.Text.Trim();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }
    }
}
