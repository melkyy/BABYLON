using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATA;
namespace GUI.DBConfig
{
    public partial class frmDBConfig : Form
    {
        ArrayList ListaPropiedades = new ArrayList();
        Database db = new Database();
        string Disco = Application.StartupPath.Substring(0, 3);
        public frmDBConfig()
        {
            InitializeComponent();
        }
        public struct strParametro
        {
            public string Nombre;
            public string Valor;
            public bool Default;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string conexion = txtCadenaBD.Text.Trim();
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    con.Close();
                    lblEstadoConexion.ForeColor = Color.Green;
                    lblEstadoConexion.Text = "Conexión exitosa";
                    lblEstadoConexion.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblEstadoConexion.ForeColor = Color.Red;
                lblEstadoConexion.Text = "Error de conexión";
                lblEstadoConexion.Visible = true;
            }
            groupBox1.Focus();
        }

        private void txtConexion_TextChanged(object sender, EventArgs e)
        {
            lblEstadoConexion.Visible = false;
        }

        private void frmCONFIG_Load(object sender, EventArgs e)
        {
            LoadDBConfig();
            LlenarListaPropiedades();
            tooTip.SetToolTip(lstLista, "Click derecho para remover un elemento");
            if (lstLista.SelectedItems.Count == 0)
            {
                lstLista.ContextMenuStrip = null;
            }
            foreach (string p in ListaPropiedades)
            {
                txtNombreNuevaPropiedad.AutoCompleteCustomSource.Add(p);
            }
        }

        private void LlenarListaPropiedades()
        {
            ListaPropiedades.Add("Application Name");
            ListaPropiedades.Add("Async");
            ListaPropiedades.Add("AttachDBFilename");
            ListaPropiedades.Add("extended properties");
            ListaPropiedades.Add("Initial File Name");
            ListaPropiedades.Add("Connect Timeout");
            ListaPropiedades.Add("Connection Timeout");
            ListaPropiedades.Add("Connection Lifetime");
            ListaPropiedades.Add("Context Connection");
            ListaPropiedades.Add("Connection Reset");
            ListaPropiedades.Add("Current Language");
            ListaPropiedades.Add("Data Source");
            ListaPropiedades.Add("Server");
            ListaPropiedades.Add("Address");
            ListaPropiedades.Add("Addr");
            ListaPropiedades.Add("Network Address");
            ListaPropiedades.Add("Encrypt");
            ListaPropiedades.Add("Enlist");
            ListaPropiedades.Add("Failover Partner");
            ListaPropiedades.Add("Initial Catalog");
            ListaPropiedades.Add("Database");
            ListaPropiedades.Add("Load Balance Timeout");
            ListaPropiedades.Add("MultipleActiveResultSets");
            ListaPropiedades.Add("Integrated Security");
            ListaPropiedades.Add("Trusted_Connection");
            ListaPropiedades.Add("Max Pool Size");
            ListaPropiedades.Add("Min Pool Size");
            ListaPropiedades.Add("Network Library");
            ListaPropiedades.Add("Net");
            ListaPropiedades.Add("Packet Size");
            ListaPropiedades.Add("Password");
            ListaPropiedades.Add("Pwd");
            ListaPropiedades.Add("Persist Security Info");
            ListaPropiedades.Add("Pooling");
            ListaPropiedades.Add("Replication");
            ListaPropiedades.Add("Transaction Binding");
            ListaPropiedades.Add("TrustServerCertificate");
            ListaPropiedades.Add("Type System Version");
            ListaPropiedades.Add("User ID");
            ListaPropiedades.Add("User Instance");
            ListaPropiedades.Add("Workstation ID");
        }
        #region Cargar parametros default
        public void LoadDefaultParameters()
        {
            strParametro strDataSource = new strParametro();
            strDataSource.Nombre = "Data Source";
            strDataSource.Valor = "asdasd";
            ListViewItem itemDataSource = new ListViewItem();
            itemDataSource.Text = strDataSource.Nombre;
            itemDataSource.Tag = strDataSource;
            lstLista.Items.Add(itemDataSource);

            strParametro strInitialCatalog = new strParametro();
            strInitialCatalog.Nombre = "Initial_Catalog";
            strInitialCatalog.Valor = "sdfsdf";
            ListViewItem itemInitialCatalog = new ListViewItem();
            itemInitialCatalog.Text = strInitialCatalog.Nombre;
            itemInitialCatalog.Tag = strInitialCatalog;
            lstLista.Items.Add(itemInitialCatalog);

            strParametro strUser = new strParametro();
            strUser.Nombre = "User ID";
            strUser.Valor = "dfgdfg";
            ListViewItem itemUser = new ListViewItem();
            itemUser.Text = strUser.Nombre;
            itemUser.Tag = strUser;
            lstLista.Items.Add(itemUser);

            strParametro strPassword = new strParametro();
            strPassword.Nombre = "Password";
            strPassword.Valor = "ytjtyj";
            ListViewItem itemPassword = new ListViewItem();
            itemPassword.Text = strPassword.Nombre;
            itemPassword.Tag = strPassword;
            lstLista.Items.Add(itemPassword);
        }
        #endregion

        public void LoadDBConfig()
        {
            string Conn = DATA.Database.ReadConnectionString();
            try
            {
                txtCadenaBD.Text = Conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SaveDBConfig()
        {
            DATA.Database.WriteConnectionString(txtCadenaBD.Text.Trim());
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                SaveDBConfig();
                MessageBox.Show("Guardado correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void cmbCadenasBD_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblEstadoConexion.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDBConfig();
        }

        public void ActualizarCadena()
        {
            string Cadena = "";
            foreach (ListViewItem item in lstLista.Items)
            {
                strParametro str = (strParametro)item.Tag;
                Cadena += str.Nombre + "=" + str.Valor + ";";
            }
            txtCadenaBD.Text = Cadena;
        }
        public void ObtenerParametros()
        {
            lstLista.Items.Clear();
            try
            {
                string Cadena = txtCadenaBD.Text.Trim();
                int NumParametros = 0;

                string[] Parametros = Cadena.Split(';');
                foreach (string par in Parametros)
                {
                    string Valor = "";
                    string Nombre = "";
                    try
                    {
                        string[] Datos = par.Split('=');
                        Nombre = Datos[0];
                        Valor = Datos[1];
                        strParametro str = new strParametro();
                        str.Nombre = Nombre;
                        str.Valor = Valor;
                        ListViewItem item = new ListViewItem();
                        item.Text = str.Nombre;
                        item.Tag = str;
                        lstLista.Items.Add(item);
                    }
                    catch
                    {

                    }
                }
            }
            catch
            {

            }
        }
        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLista.SelectedItems.Count == 0)
            {
                txtValorPropiedad.Enabled = false;
                lstLista.ContextMenuStrip = null;
            }
            else
            {
                lstLista.ContextMenuStrip = MenuStrip;
                try
                {
                    strParametro str = (strParametro)lstLista.SelectedItems[0].Tag;
                    ListViewItem selected = lstLista.SelectedItems[0];
                    txtValorPropiedad.Enabled = true;
                    txtNombrePropiedad.Text = str.Nombre;
                    txtValorPropiedad.Text = str.Valor;

                    foreach (ListViewItem item in lstLista.Items)
                    {
                        if (item.Text.Equals(selected.Text))
                        {
                            item.ForeColor = Color.White;
                            item.BackColor = Color.Gray;
                        }
                    }
                }
                catch
                {

                }
            }
        }

        private void txtCadenaBD_TextChanged(object sender, EventArgs e)
        {
            ObtenerParametros();
        }

        private void txtValorParametro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewItem newitem = new ListViewItem();
                strParametro str = new strParametro();
                str.Nombre = txtNombrePropiedad.Text.Trim();
                str.Valor = txtValorPropiedad.Text.Trim();

                ArrayList Parametros = new ArrayList();

                foreach (ListViewItem item in lstLista.Items)
                {
                    strParametro p = (strParametro)item.Tag;
                    if (!p.Nombre.Equals(str.Nombre))
                    {
                        Parametros.Add(item);
                    }
                }
                newitem.Text = str.Nombre;
                newitem.Tag = str;
                if (str.Nombre != "")
                {
                    Parametros.Add(newitem);
                }
                lstLista.Items.Clear();

                foreach (ListViewItem i in Parametros)
                {
                    lstLista.Items.Add(i);
                }
            }
            catch
            {

            }
            ActualizarCadena();
            foreach (ListViewItem item in lstLista.Items)
            {
                if (item.Text.Equals(txtNombrePropiedad.Text))
                {
                    item.ForeColor = Color.White;
                    item.BackColor = Color.Gray;
                }
                item.ForeColor = Color.Black;
                item.BackColor = Color.Gainsboro;
            }

        }

        private void btnAgregarParametro_Click(object sender, EventArgs e)
        {
            groupAgregarParametro.Visible = true;
            txtNombreNuevaPropiedad.Focus();
        }

        private void btnRemoverParametro_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstLista.Items)
            {
                if (item.BackColor == Color.Gray)
                {
                    strParametro str = (strParametro)item.Tag;
                    DialogResult Resultado = MessageBox.Show("Remover propiedad '" + str.Nombre + "'", "Remover propiedad", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (Resultado == DialogResult.OK)
                    {
                        foreach (ListViewItem i in lstLista.Items)
                        {
                            if (i.Text.Equals(str.Nombre))
                            {
                                i.Remove();
                                txtNombrePropiedad.Text = "";
                                txtValorPropiedad.Text = "";
                                ActualizarCadena();
                                ObtenerParametros();
                                txtValorPropiedad.Enabled = false;
                            }
                        }
                    }
                    else
                    {

                    }
                    break;
                }
            }

        }

        private void btnCancelarParam_Click(object sender, EventArgs e)
        {
            txtNombreNuevaPropiedad.Text = "";
            txtValorNuevaPropiedad.Text = "";
            groupAgregarParametro.Visible = false;
        }

        private void btnAceptarParam_Click(object sender, EventArgs e)
        {
            groupAgregarParametro.Focus();
            AgregarPropiedad();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtCadenaBD.Text = "";
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoverPropiedad();
        }

        private void txtNombreNuevoParametro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtValorNuevaPropiedad.Focus();
            }
        }

        private void txtValorNuevoParametro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AgregarPropiedad();
            }
        }

        #region Agregar propiedad
        private void AgregarPropiedad()
        {
            strParametro str = new strParametro();
            str.Nombre = txtNombreNuevaPropiedad.Text.Trim();
            str.Valor = txtValorNuevaPropiedad.Text.Trim();

            bool ExisteParametro = false;
            foreach (ListViewItem i in lstLista.Items)
            {
                if (i.Text.Equals(str.Nombre, StringComparison.InvariantCultureIgnoreCase))
                {
                    ExisteParametro = true;
                }
            }
            if (txtNombreNuevaPropiedad.Text != "" && txtValorNuevaPropiedad.Text != "")
            {
                if (!ExisteParametro)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = str.Nombre;
                    item.Tag = str;
                    lstLista.Items.Add(item);
                    MessageBox.Show("Propiedad agregada", "Agregar propiedad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombreNuevaPropiedad.Text = "";
                    txtValorNuevaPropiedad.Text = "";
                    ActualizarCadena();
                }
                else
                {
                    MessageBox.Show("La propiedad ya existe", "Agregar propiedad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Hay campos vacíos", "Agregar propiedad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Remover propiedad
        private void RemoverPropiedad()
        {
            foreach (ListViewItem item in lstLista.Items)
            {
                if (item.BackColor == Color.Gray)
                {
                    strParametro str = (strParametro)item.Tag;
                    DialogResult Resultado = MessageBox.Show("Remover propiedad '" + str.Nombre + "'", "Remover propiedad", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (Resultado == DialogResult.OK)
                    {
                        foreach (ListViewItem i in lstLista.Items)
                        {
                            if (i.Text.Equals(str.Nombre))
                            {
                                i.Remove();
                                txtNombrePropiedad.Text = "";
                                txtValorPropiedad.Text = "";
                                ActualizarCadena();
                                ObtenerParametros();
                                txtValorPropiedad.Enabled = false;
                            }
                        }
                    }
                    else
                    {

                    }
                    break;
                }
            }
        }
        #endregion
    }
}
