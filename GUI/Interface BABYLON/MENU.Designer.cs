namespace GUI.Interface_BABYLON
{
    partial class MENU
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeUnidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capturaDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-53, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1997, 1058);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem,
            this.capturasToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1020, 33);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDeProductosToolStripMenuItem,
            this.tipoDeUnidadToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.administrarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(125, 29);
            this.administrarToolStripMenuItem.Text = "Administrar";
            // 
            // tipoDeProductosToolStripMenuItem
            // 
            this.tipoDeProductosToolStripMenuItem.Name = "tipoDeProductosToolStripMenuItem";
            this.tipoDeProductosToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.tipoDeProductosToolStripMenuItem.Text = "Tipo de Productos";
            this.tipoDeProductosToolStripMenuItem.Click += new System.EventHandler(this.tipoDeProductosToolStripMenuItem_Click);
            // 
            // tipoDeUnidadToolStripMenuItem
            // 
            this.tipoDeUnidadToolStripMenuItem.Name = "tipoDeUnidadToolStripMenuItem";
            this.tipoDeUnidadToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.tipoDeUnidadToolStripMenuItem.Text = "Tipo de Unidad";
            this.tipoDeUnidadToolStripMenuItem.Click += new System.EventHandler(this.tipoDeUnidadToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
<<<<<<< HEAD
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
=======
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click_1);
>>>>>>> Despues de la entrega estos son los archivos de la entrega
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // capturasToolStripMenuItem
            // 
            this.capturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capturaDeVentaToolStripMenuItem});
            this.capturasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capturasToolStripMenuItem.Name = "capturasToolStripMenuItem";
            this.capturasToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.capturasToolStripMenuItem.Text = "Capturas";
            // 
            // capturaDeVentaToolStripMenuItem
            // 
            this.capturaDeVentaToolStripMenuItem.Name = "capturaDeVentaToolStripMenuItem";
            this.capturaDeVentaToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.capturaDeVentaToolStripMenuItem.Text = "Captura de Venta";
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 733);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MENU";
            this.Text = "MENU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MENU_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeUnidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capturaDeVentaToolStripMenuItem;
    }
}