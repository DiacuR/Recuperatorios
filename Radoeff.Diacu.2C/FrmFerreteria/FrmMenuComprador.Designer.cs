namespace FrmFerreteria
{
    partial class FrmMenuComprador
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiComprar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMostrarTodosLosProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbAmbito = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMostrar
            // 
            this.lbMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbMostrar.HorizontalExtent = 1100;
            this.lbMostrar.HorizontalScrollbar = true;
            this.lbMostrar.ItemHeight = 16;
            this.lbMostrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbMostrar.ScrollAlwaysVisible = true;
            this.lbMostrar.Size = new System.Drawing.Size(1005, 276);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Location = new System.Drawing.Point(160, 33);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiComprar,
            this.tsmiMostrarTodosLosProductos,
            this.cerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(11, 137);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(501, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiComprar
            // 
            this.tsmiComprar.Name = "tsmiComprar";
            this.tsmiComprar.Size = new System.Drawing.Size(81, 24);
            this.tsmiComprar.Text = "Comprar";
            this.tsmiComprar.Click += new System.EventHandler(this.tsmiComprar_Click);
            // 
            // tsmiMostrarTodosLosProductos
            // 
            this.tsmiMostrarTodosLosProductos.Name = "tsmiMostrarTodosLosProductos";
            this.tsmiMostrarTodosLosProductos.Size = new System.Drawing.Size(210, 24);
            this.tsmiMostrarTodosLosProductos.Text = "Mostrar todos los productos";
            this.tsmiMostrarTodosLosProductos.Click += new System.EventHandler(this.tsmiMostrarTodosLosProductos_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.cerrarToolStripMenuItem.Text = "Salir";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(929, 115);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(765, 116);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(158, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // cmbAmbito
            // 
            this.cmbAmbito.FormattingEnabled = true;
            this.cmbAmbito.Location = new System.Drawing.Point(765, 162);
            this.cmbAmbito.Name = "cmbAmbito";
            this.cmbAmbito.Size = new System.Drawing.Size(158, 24);
            this.cmbAmbito.TabIndex = 5;
            // 
            // FrmMenuComprador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1028, 476);
            this.Controls.Add(this.cmbAmbito);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenuComprador";
            this.Text = "FrmMenuComprador";
            this.Load += new System.EventHandler(this.FrmMenuComprador_Load);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.lblBienvenida, 0);
            this.Controls.SetChildIndex(this.lbMostrar, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.cmbAmbito, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiComprar;
        private System.Windows.Forms.ToolStripMenuItem tsmiMostrarTodosLosProductos;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbAmbito;
    }
}