namespace FrmFerreteria
{
    partial class FrmMenuPrincipal
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
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lbMostrar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.lblBienvenida.Location = new System.Drawing.Point(43, 46);
            this.lblBienvenida.MinimumSize = new System.Drawing.Size(700, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(700, 37);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenida";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMostrar
            // 
            this.lbMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMostrar.FormattingEnabled = true;
            this.lbMostrar.ItemHeight = 25;
            this.lbMostrar.Location = new System.Drawing.Point(11, 192);
            this.lbMostrar.Name = "lbMostrar";
            this.lbMostrar.Size = new System.Drawing.Size(783, 279);
            this.lbMostrar.TabIndex = 1;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 476);
            this.Controls.Add(this.lbMostrar);
            this.Controls.Add(this.lblBienvenida);
            this.Name = "FrmMenuPrincipal";
            this.Text = "FrmMenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.ListBox lbMostrar;
        protected System.Windows.Forms.Label lblBienvenida;
    }
}