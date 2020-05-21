namespace FrmFerreteria
{
    partial class FrmAltaSierra
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCantDeDientes = new System.Windows.Forms.Label();
            this.cmbMaterialQueCorta = new System.Windows.Forms.ComboBox();
            this.lblMaterialQueCorta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbAmbito
            // 
            this.cmbAmbito.Size = new System.Drawing.Size(160, 24);
            // 
            // comboBox1
            // 
            this.cmbExperiencia.Size = new System.Drawing.Size(160, 24);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(594, 174);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(328, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 22);
            this.textBox1.TabIndex = 11;
            // 
            // lblCantDeDientes
            // 
            this.lblCantDeDientes.AutoSize = true;
            this.lblCantDeDientes.Location = new System.Drawing.Point(330, 253);
            this.lblCantDeDientes.Name = "lblCantDeDientes";
            this.lblCantDeDientes.Size = new System.Drawing.Size(134, 17);
            this.lblCantDeDientes.TabIndex = 12;
            this.lblCantDeDientes.Text = "Cantidad de dientes";
            // 
            // cmbMaterialQueCorta
            // 
            this.cmbMaterialQueCorta.FormattingEnabled = true;
            this.cmbMaterialQueCorta.Location = new System.Drawing.Point(594, 94);
            this.cmbMaterialQueCorta.Name = "cmbMaterialQueCorta";
            this.cmbMaterialQueCorta.Size = new System.Drawing.Size(152, 24);
            this.cmbMaterialQueCorta.TabIndex = 13;
            // 
            // lblMaterialQueCorta
            // 
            this.lblMaterialQueCorta.AutoSize = true;
            this.lblMaterialQueCorta.Location = new System.Drawing.Point(608, 74);
            this.lblMaterialQueCorta.Name = "lblMaterialQueCorta";
            this.lblMaterialQueCorta.Size = new System.Drawing.Size(122, 17);
            this.lblMaterialQueCorta.TabIndex = 14;
            this.lblMaterialQueCorta.Text = "Material que corta";
            // 
            // FrmAltaSierra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 353);
            this.Controls.Add(this.lblMaterialQueCorta);
            this.Controls.Add(this.cmbMaterialQueCorta);
            this.Controls.Add(this.lblCantDeDientes);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmAltaSierra";
            this.Text = "FrmAltaSierra";
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            this.Controls.SetChildIndex(this.txtStock, 0);
            this.Controls.SetChildIndex(this.cmbAmbito, 0);
            this.Controls.SetChildIndex(this.cmbExperiencia, 0);
            this.Controls.SetChildIndex(this.btnAgregarProducto, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.lblCantDeDientes, 0);
            this.Controls.SetChildIndex(this.cmbMaterialQueCorta, 0);
            this.Controls.SetChildIndex(this.lblMaterialQueCorta, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCantDeDientes;
        private System.Windows.Forms.ComboBox cmbMaterialQueCorta;
        private System.Windows.Forms.Label lblMaterialQueCorta;
    }
}