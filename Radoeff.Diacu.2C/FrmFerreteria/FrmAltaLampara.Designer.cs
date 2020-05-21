namespace FrmFerreteria
{
    partial class FrmAltaLampara
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
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblConsumoElectrico = new System.Windows.Forms.Label();
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
            this.btnAgregarProducto.Location = new System.Drawing.Point(583, 176);
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(583, 94);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(121, 24);
            this.cmbColor.TabIndex = 11;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(580, 74);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(41, 17);
            this.lblColor.TabIndex = 12;
            this.lblColor.Text = "Color";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(328, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 22);
            this.textBox1.TabIndex = 13;
            // 
            // lblConsumoElectrico
            // 
            this.lblConsumoElectrico.AutoSize = true;
            this.lblConsumoElectrico.Location = new System.Drawing.Point(325, 253);
            this.lblConsumoElectrico.Name = "lblConsumoElectrico";
            this.lblConsumoElectrico.Size = new System.Drawing.Size(124, 17);
            this.lblConsumoElectrico.TabIndex = 14;
            this.lblConsumoElectrico.Text = "Consumo electrico";
            // 
            // FrmAltaLampara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 363);
            this.Controls.Add(this.lblConsumoElectrico);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cmbColor);
            this.Name = "FrmAltaLampara";
            this.Text = "FrmAltaLampara";
            this.Load += new System.EventHandler(this.FrmAltaLampara_Load);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            this.Controls.SetChildIndex(this.txtStock, 0);
            this.Controls.SetChildIndex(this.cmbAmbito, 0);
            this.Controls.SetChildIndex(this.cmbExperiencia, 0);
            this.Controls.SetChildIndex(this.btnAgregarProducto, 0);
            this.Controls.SetChildIndex(this.cmbColor, 0);
            this.Controls.SetChildIndex(this.lblColor, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.lblConsumoElectrico, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblConsumoElectrico;
    }
}