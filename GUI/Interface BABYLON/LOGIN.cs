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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            LOGIC.BABYUsuarios Metodo = new LOGIC.BABYUsuarios();

            if (TxtUsuario.Text.Trim() != "" && TxtContraseña.Text.Trim() != "")
            {

                if (Metodo.VerificarUsuario(TxtUsuario.Text, TxtContraseña.Text))
                {

                    this.Visible=false;
                    
                }
                else {
                    MessageBox.Show("Nombre de Usuario o contraseña Incorrecto");
                }

            }
            else {
                MessageBox.Show("CAMPOS VACIOS");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LOGIN_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void LOGIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
