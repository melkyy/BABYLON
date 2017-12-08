namespace GUI.DBConfig
{
    partial class frmDBConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDBConfig));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tooTip = new System.Windows.Forms.ToolTip(this.components);
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblEstadoConexion = new System.Windows.Forms.Label();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstLista = new System.Windows.Forms.ListView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregarProp = new System.Windows.Forms.Button();
            this.txtNombreNuevaPropiedad = new System.Windows.Forms.TextBox();
            this.txtNombrePropiedad = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtValorNuevaPropiedad = new System.Windows.Forms.TextBox();
            this.lblParam = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValorPropiedad = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupDetallesParam = new System.Windows.Forms.GroupBox();
            this.txtCadenaBD = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupAgregarParametro = new System.Windows.Forms.GroupBox();
            this.pagDATABASE = new System.Windows.Forms.TabPage();
            this.tabPestanas = new System.Windows.Forms.TabControl();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupDetallesParam.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupAgregarParametro.SuspendLayout();
            this.pagDATABASE.SuspendLayout();
            this.tabPestanas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Image = global::GUI.Properties.Resources._1458255648_checkmark_24;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(650, 368);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(92, 29);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // tooTip
            // 
            this.tooTip.IsBalloon = true;
            this.tooTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tooTip.ToolTipTitle = "Lista de propiedades";
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.MintCream;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerificar.Location = new System.Drawing.Point(727, 264);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(93, 26);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblEstadoConexion
            // 
            this.lblEstadoConexion.AutoSize = true;
            this.lblEstadoConexion.Location = new System.Drawing.Point(672, 297);
            this.lblEstadoConexion.Name = "lblEstadoConexion";
            this.lblEstadoConexion.Size = new System.Drawing.Size(0, 13);
            this.lblEstadoConexion.TabIndex = 3;
            this.lblEstadoConexion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEstadoConexion.Visible = false;
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removerToolStripMenuItem.Text = "Remover";
            this.removerToolStripMenuItem.Click += new System.EventHandler(this.removerToolStripMenuItem_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removerToolStripMenuItem});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(153, 48);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Propiedad";
            this.columnHeader1.Width = 235;
            // 
            // lstLista
            // 
            this.lstLista.BackColor = System.Drawing.Color.Gainsboro;
            this.lstLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstLista.ContextMenuStrip = this.MenuStrip;
            this.lstLista.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstLista.FullRowSelect = true;
            this.lstLista.GridLines = true;
            this.lstLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstLista.Location = new System.Drawing.Point(9, 21);
            this.lstLista.MultiSelect = false;
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(241, 211);
            this.lstLista.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstLista.TabIndex = 11;
            this.lstLista.UseCompatibleStateImageBehavior = false;
            this.lstLista.View = System.Windows.Forms.View.Details;
            this.lstLista.SelectedIndexChanged += new System.EventHandler(this.lstLista_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Image = global::GUI.Properties.Resources._1458255661_No;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(748, 368);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 29);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregarProp
            // 
            this.btnAgregarProp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarProp.Image = global::GUI.Properties.Resources._1458255976_plus_24;
            this.btnAgregarProp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProp.Location = new System.Drawing.Point(233, 84);
            this.btnAgregarProp.Name = "btnAgregarProp";
            this.btnAgregarProp.Size = new System.Drawing.Size(93, 29);
            this.btnAgregarProp.TabIndex = 23;
            this.btnAgregarProp.Text = "Agregar";
            this.btnAgregarProp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProp.UseVisualStyleBackColor = true;
            this.btnAgregarProp.Click += new System.EventHandler(this.btnAceptarParam_Click);
            // 
            // txtNombreNuevaPropiedad
            // 
            this.txtNombreNuevaPropiedad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNombreNuevaPropiedad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNombreNuevaPropiedad.Location = new System.Drawing.Point(76, 21);
            this.txtNombreNuevaPropiedad.Name = "txtNombreNuevaPropiedad";
            this.txtNombreNuevaPropiedad.Size = new System.Drawing.Size(250, 20);
            this.txtNombreNuevaPropiedad.TabIndex = 19;
            this.txtNombreNuevaPropiedad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombreNuevoParametro_KeyDown);
            // 
            // txtNombrePropiedad
            // 
            this.txtNombrePropiedad.BackColor = System.Drawing.SystemColors.Info;
            this.txtNombrePropiedad.Location = new System.Drawing.Point(76, 22);
            this.txtNombrePropiedad.Name = "txtNombrePropiedad";
            this.txtNombrePropiedad.ReadOnly = true;
            this.txtNombrePropiedad.Size = new System.Drawing.Size(250, 20);
            this.txtNombrePropiedad.TabIndex = 15;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 14;
            this.label19.Text = "Nombre:";
            // 
            // txtValorNuevaPropiedad
            // 
            this.txtValorNuevaPropiedad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtValorNuevaPropiedad.Location = new System.Drawing.Point(76, 49);
            this.txtValorNuevaPropiedad.Name = "txtValorNuevaPropiedad";
            this.txtValorNuevaPropiedad.Size = new System.Drawing.Size(250, 20);
            this.txtValorNuevaPropiedad.TabIndex = 22;
            this.txtValorNuevaPropiedad.TextChanged += new System.EventHandler(this.txtValorParametro_TextChanged);
            this.txtValorNuevaPropiedad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorNuevoParametro_KeyDown);
            // 
            // lblParam
            // 
            this.lblParam.AutoSize = true;
            this.lblParam.Location = new System.Drawing.Point(6, 24);
            this.lblParam.Name = "lblParam";
            this.lblParam.Size = new System.Drawing.Size(47, 13);
            this.lblParam.TabIndex = 20;
            this.lblParam.Text = "Nombre:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(14, 52);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 21;
            this.lblValor.Text = "Valor:";
            // 
            // txtValorPropiedad
            // 
            this.txtValorPropiedad.Enabled = false;
            this.txtValorPropiedad.Location = new System.Drawing.Point(76, 50);
            this.txtValorPropiedad.Name = "txtValorPropiedad";
            this.txtValorPropiedad.Size = new System.Drawing.Size(250, 20);
            this.txtValorPropiedad.TabIndex = 13;
            this.txtValorPropiedad.TextChanged += new System.EventHandler(this.txtValorParametro_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 53);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Valor:";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(615, 58);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(178, 110);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 25;
            this.pictureBox.TabStop = false;
            // 
            // groupDetallesParam
            // 
            this.groupDetallesParam.BackColor = System.Drawing.Color.Gainsboro;
            this.groupDetallesParam.Controls.Add(this.txtValorPropiedad);
            this.groupDetallesParam.Controls.Add(this.label18);
            this.groupDetallesParam.Controls.Add(this.txtNombrePropiedad);
            this.groupDetallesParam.Controls.Add(this.label19);
            this.groupDetallesParam.Location = new System.Drawing.Point(256, 21);
            this.groupDetallesParam.Name = "groupDetallesParam";
            this.groupDetallesParam.Size = new System.Drawing.Size(335, 86);
            this.groupDetallesParam.TabIndex = 24;
            this.groupDetallesParam.TabStop = false;
            this.groupDetallesParam.Text = "Detalles";
            // 
            // txtCadenaBD
            // 
            this.txtCadenaBD.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCadenaBD.Location = new System.Drawing.Point(6, 266);
            this.txtCadenaBD.Name = "txtCadenaBD";
            this.txtCadenaBD.Size = new System.Drawing.Size(718, 20);
            this.txtCadenaBD.TabIndex = 7;
            this.txtCadenaBD.Text = "Data Source=10.21.6.37;Initial Catalog=JOHNDEERE;User ID=sistema;Password=12345";
            this.txtCadenaBD.TextChanged += new System.EventHandler(this.txtCadenaBD_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 247);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Cadena de conexión";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.groupDetallesParam);
            this.groupBox1.Controls.Add(this.groupAgregarParametro);
            this.groupBox1.Controls.Add(this.lstLista);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 238);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrar conexión";
            // 
            // groupAgregarParametro
            // 
            this.groupAgregarParametro.BackColor = System.Drawing.Color.MintCream;
            this.groupAgregarParametro.Controls.Add(this.btnAgregarProp);
            this.groupAgregarParametro.Controls.Add(this.txtNombreNuevaPropiedad);
            this.groupAgregarParametro.Controls.Add(this.txtValorNuevaPropiedad);
            this.groupAgregarParametro.Controls.Add(this.lblParam);
            this.groupAgregarParametro.Controls.Add(this.lblValor);
            this.groupAgregarParametro.Location = new System.Drawing.Point(256, 113);
            this.groupAgregarParametro.Name = "groupAgregarParametro";
            this.groupAgregarParametro.Size = new System.Drawing.Size(335, 119);
            this.groupAgregarParametro.TabIndex = 23;
            this.groupAgregarParametro.TabStop = false;
            this.groupAgregarParametro.Text = "Agregar propiedad";
            // 
            // pagDATABASE
            // 
            this.pagDATABASE.Controls.Add(this.txtCadenaBD);
            this.pagDATABASE.Controls.Add(this.label17);
            this.pagDATABASE.Controls.Add(this.groupBox1);
            this.pagDATABASE.Controls.Add(this.btnVerificar);
            this.pagDATABASE.Controls.Add(this.lblEstadoConexion);
            this.pagDATABASE.Location = new System.Drawing.Point(4, 22);
            this.pagDATABASE.Name = "pagDATABASE";
            this.pagDATABASE.Padding = new System.Windows.Forms.Padding(3);
            this.pagDATABASE.Size = new System.Drawing.Size(826, 322);
            this.pagDATABASE.TabIndex = 0;
            this.pagDATABASE.Text = "DATABASE";
            this.pagDATABASE.UseVisualStyleBackColor = true;
            // 
            // tabPestanas
            // 
            this.tabPestanas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPestanas.Controls.Add(this.pagDATABASE);
            this.tabPestanas.Location = new System.Drawing.Point(14, 13);
            this.tabPestanas.Margin = new System.Windows.Forms.Padding(4);
            this.tabPestanas.Name = "tabPestanas";
            this.tabPestanas.SelectedIndex = 0;
            this.tabPestanas.Size = new System.Drawing.Size(834, 348);
            this.tabPestanas.TabIndex = 3;
            // 
            // frmDBConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 410);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tabPestanas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDBConfig";
            this.Text = "Configurar conexión a base de datos";
            this.Load += new System.EventHandler(this.frmCONFIG_Load);
            this.MenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupDetallesParam.ResumeLayout(false);
            this.groupDetallesParam.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupAgregarParametro.ResumeLayout(false);
            this.groupAgregarParametro.PerformLayout();
            this.pagDATABASE.ResumeLayout(false);
            this.pagDATABASE.PerformLayout();
            this.tabPestanas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ToolTip tooTip;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblEstadoConexion;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lstLista;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregarProp;
        private System.Windows.Forms.TextBox txtNombreNuevaPropiedad;
        private System.Windows.Forms.TextBox txtNombrePropiedad;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtValorNuevaPropiedad;
        private System.Windows.Forms.Label lblParam;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValorPropiedad;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupDetallesParam;
        private System.Windows.Forms.TextBox txtCadenaBD;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupAgregarParametro;
        private System.Windows.Forms.TabPage pagDATABASE;
        private System.Windows.Forms.TabControl tabPestanas;
    }
}