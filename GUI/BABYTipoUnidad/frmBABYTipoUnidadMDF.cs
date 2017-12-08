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
    public partial class frmBABYTipoUnidadMDF : Form
    {
        public int id;
        public frmBABYTipoUnidadMDF()
        {
            InitializeComponent();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            DATA.BABYTipoUnidad tabla = new DATA.BABYTipoUnidad();
            DATA.BABYTipoUnidad.DataBABYTipoUnidad str = new DATA.BABYTipoUnidad.DataBABYTipoUnidad();
            str.idTipoUnidad = id;
            str.NombreTipoUnidad = txtNombre.Text.Trim();
            if(tabla.Modificar(str) == BABY.enmResultados.OperacionCorrecta)
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
