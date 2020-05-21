namespace FrmFerreteria
{
    partial class FrmAltaPintura
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
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.lblLitros = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbLugarDeUso = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnAgregarProducto.Location = new System.Drawing.Point(597, 265);
            this.btnAgregarProducto.Size = new System.Drawing.Size(160, 30);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtNombre.MinimumSize = new System.Drawing.Size(100, 25);
            this.txtNombre.Size = new System.Drawing.Size(170, 25);
            // 
            // txtLitros
            // 
            this.txtLitros.Location = new System.Drawing.Point(328, 273);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(152, 22);
            this.txtLitros.TabIndex = 11;
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(330, 253);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(43, 17);
            this.lblLitros.TabIndex = 12;
            this.lblLitros.Text = "Litros";
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(597, 95);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(160, 24);
            this.cmbColor.TabIndex = 13;
            // 
            // cmbLugarDeUso
            // 
            this.cmbLugarDeUso.FormattingEnabled = true;
            this.cmbLugarDeUso.Location = new System.Drawing.Point(597, 182);
            this.cmbLugarDeUso.Name = "cmbLugarDeUso";
            this.cmbLugarDeUso.Size = new System.Drawing.Size(160, 24);
            this.cmbLugarDeUso.TabIndex = 14;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(594, 74);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(41, 17);
            this.lblColor.TabIndex = 15;
            this.lblColor.Text = "Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Lugar De Uso";
            // 
            // FrmAltaPintura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cmbLugarDeUso);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.txtLitros);
            this.Name = "FrmAltaPintura";
            this.Text = "FrmAltaPintura";
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            this.Controls.SetChildIndex(this.txtStock, 0);
            this.Controls.SetChildIndex(this.cmbAmbito, 0);
            this.Controls.SetChildIndex(this.cmbExperiencia, 0);
            this.Controls.SetChildIndex(this.btnAgregarProducto, 0);
            this.Controls.SetChildIndex(this.txtLitros, 0);
            this.Controls.SetChildIndex(this.lblLitros, 0);
            this.Controls.SetChildIndex(this.cmbColor, 0);
            this.Controls.SetChildIndex(this.cmbLugarDeUso, 0);
            this.Controls.SetChildIndex(this.lblColor, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbLugarDeUso;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label label1;
    }
}