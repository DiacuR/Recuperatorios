namespace FrmFerreteria
{
    partial class FrmAltaProducto
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.cmbAmbito = new System.Windows.Forms.ComboBox();
            this.lblAmbito = new System.Windows.Forms.Label();
            this.cmbExperiencia = new System.Windows.Forms.ComboBox();
            this.lblExpDelUsuario = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(69, 94);
            this.txtNombre.MaximumSize = new System.Drawing.Size(500, 100);
            this.txtNombre.MinimumSize = new System.Drawing.Size(100, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(170, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(69, 182);
            this.txtPrecio.MaximumSize = new System.Drawing.Size(500, 100);
            this.txtPrecio.MinimumSize = new System.Drawing.Size(100, 30);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(170, 22);
            this.txtPrecio.TabIndex = 1;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(69, 273);
            this.txtStock.MaximumSize = new System.Drawing.Size(500, 100);
            this.txtStock.MinimumSize = new System.Drawing.Size(100, 30);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(170, 22);
            this.txtStock.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(66, 74);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(66, 162);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(48, 17);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(66, 253);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(43, 17);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "Stock";
            // 
            // cmbAmbito
            // 
            this.cmbAmbito.FormattingEnabled = true;
            this.cmbAmbito.Location = new System.Drawing.Point(328, 94);
            this.cmbAmbito.MaximumSize = new System.Drawing.Size(500, 0);
            this.cmbAmbito.MinimumSize = new System.Drawing.Size(100, 0);
            this.cmbAmbito.Name = "cmbAmbito";
            this.cmbAmbito.Size = new System.Drawing.Size(160, 24);
            this.cmbAmbito.TabIndex = 6;
            // 
            // lblAmbito
            // 
            this.lblAmbito.AutoSize = true;
            this.lblAmbito.Location = new System.Drawing.Point(325, 74);
            this.lblAmbito.Name = "lblAmbito";
            this.lblAmbito.Size = new System.Drawing.Size(51, 17);
            this.lblAmbito.TabIndex = 7;
            this.lblAmbito.Text = "Ambito";
            // 
            // cmbExperiencia
            // 
            this.cmbExperiencia.FormattingEnabled = true;
            this.cmbExperiencia.Location = new System.Drawing.Point(328, 182);
            this.cmbExperiencia.MaximumSize = new System.Drawing.Size(500, 0);
            this.cmbExperiencia.MinimumSize = new System.Drawing.Size(100, 0);
            this.cmbExperiencia.Name = "cmbExperiencia";
            this.cmbExperiencia.Size = new System.Drawing.Size(160, 24);
            this.cmbExperiencia.TabIndex = 8;
            // 
            // lblExpDelUsuario
            // 
            this.lblExpDelUsuario.AutoSize = true;
            this.lblExpDelUsuario.Location = new System.Drawing.Point(325, 162);
            this.lblExpDelUsuario.Name = "lblExpDelUsuario";
            this.lblExpDelUsuario.Size = new System.Drawing.Size(155, 17);
            this.lblExpDelUsuario.TabIndex = 9;
            this.lblExpDelUsuario.Text = "Experiencia del usuario";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(328, 273);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(152, 30);
            this.btnAgregarProducto.TabIndex = 10;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // FrmAltaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 394);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.lblExpDelUsuario);
            this.Controls.Add(this.cmbExperiencia);
            this.Controls.Add(this.lblAmbito);
            this.Controls.Add(this.cmbAmbito);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Name = "FrmAltaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAltaProducto";
            this.Load += new System.EventHandler(this.FrmAltaProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        protected System.Windows.Forms.ComboBox cmbAmbito;
        private System.Windows.Forms.Label lblAmbito;
        protected System.Windows.Forms.TextBox txtPrecio;
        protected System.Windows.Forms.ComboBox cmbExperiencia;
        private System.Windows.Forms.Label lblExpDelUsuario;
        protected System.Windows.Forms.Button btnAgregarProducto;
        protected System.Windows.Forms.TextBox txtNombre;
        protected System.Windows.Forms.TextBox txtStock;
    }
}