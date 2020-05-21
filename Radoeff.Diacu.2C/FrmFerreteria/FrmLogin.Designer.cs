namespace FrmFerreteria
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVendedor = new System.Windows.Forms.Button();
            this.btnComprador = new System.Windows.Forms.Button();
            this.txtNombreDeUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVendedor
            // 
            this.btnVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.btnVendedor.Location = new System.Drawing.Point(12, 312);
            this.btnVendedor.Name = "btnVendedor";
            this.btnVendedor.Size = new System.Drawing.Size(136, 43);
            this.btnVendedor.TabIndex = 0;
            this.btnVendedor.Text = "Vendedor";
            this.btnVendedor.UseVisualStyleBackColor = true;
            this.btnVendedor.Click += new System.EventHandler(this.btnVendedor_Click);
            // 
            // btnComprador
            // 
            this.btnComprador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.btnComprador.Location = new System.Drawing.Point(208, 312);
            this.btnComprador.Name = "btnComprador";
            this.btnComprador.Size = new System.Drawing.Size(136, 43);
            this.btnComprador.TabIndex = 1;
            this.btnComprador.Text = "Comprador";
            this.btnComprador.UseVisualStyleBackColor = true;
            this.btnComprador.Click += new System.EventHandler(this.btnComprador_Click);
            // 
            // txtNombreDeUsuario
            // 
            this.txtNombreDeUsuario.Location = new System.Drawing.Point(80, 132);
            this.txtNombreDeUsuario.Name = "txtNombreDeUsuario";
            this.txtNombreDeUsuario.Size = new System.Drawing.Size(182, 22);
            this.txtNombreDeUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(80, 215);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(182, 22);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(77, 112);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(77, 195);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(81, 17);
            this.lblContraseña.TabIndex = 5;
            this.lblContraseña.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cualquier contraseña";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtNombreDeUsuario);
            this.Controls.Add(this.btnComprador);
            this.Controls.Add(this.btnVendedor);
            this.Name = "FrmLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVendedor;
        private System.Windows.Forms.Button btnComprador;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        public System.Windows.Forms.TextBox txtNombreDeUsuario;
        private System.Windows.Forms.Label label2;
    }
}

