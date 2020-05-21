namespace FrmFerreteria
{
    partial class FrmComprar
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
            this.lbCarrito = new System.Windows.Forms.ListBox();
            this.lbProductos = new System.Windows.Forms.ListBox();
            this.btnAgregarACarrito = new System.Windows.Forms.Button();
            this.btnQuitarDeCarrito = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiRealizarCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCancelarCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCarrito = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCarrito
            // 
            this.lbCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbCarrito.FormattingEnabled = true;
            this.lbCarrito.HorizontalExtent = 700;
            this.lbCarrito.HorizontalScrollbar = true;
            this.lbCarrito.ItemHeight = 16;
            this.lbCarrito.Location = new System.Drawing.Point(12, 95);
            this.lbCarrito.Name = "lbCarrito";
            this.lbCarrito.Size = new System.Drawing.Size(348, 420);
            this.lbCarrito.TabIndex = 0;
            // 
            // lbProductos
            // 
            this.lbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbProductos.FormattingEnabled = true;
            this.lbProductos.HorizontalExtent = 700;
            this.lbProductos.HorizontalScrollbar = true;
            this.lbProductos.ItemHeight = 16;
            this.lbProductos.Location = new System.Drawing.Point(509, 95);
            this.lbProductos.Name = "lbProductos";
            this.lbProductos.Size = new System.Drawing.Size(348, 420);
            this.lbProductos.TabIndex = 1;
            // 
            // btnAgregarACarrito
            // 
            this.btnAgregarACarrito.Location = new System.Drawing.Point(366, 168);
            this.btnAgregarACarrito.Name = "btnAgregarACarrito";
            this.btnAgregarACarrito.Size = new System.Drawing.Size(137, 43);
            this.btnAgregarACarrito.TabIndex = 2;
            this.btnAgregarACarrito.Text = "button1";
            this.btnAgregarACarrito.UseVisualStyleBackColor = true;
            this.btnAgregarACarrito.Click += new System.EventHandler(this.btnAgregarACarrito_Click);
            // 
            // btnQuitarDeCarrito
            // 
            this.btnQuitarDeCarrito.Location = new System.Drawing.Point(366, 319);
            this.btnQuitarDeCarrito.Name = "btnQuitarDeCarrito";
            this.btnQuitarDeCarrito.Size = new System.Drawing.Size(137, 43);
            this.btnQuitarDeCarrito.TabIndex = 3;
            this.btnQuitarDeCarrito.Text = "button2";
            this.btnQuitarDeCarrito.UseVisualStyleBackColor = true;
            this.btnQuitarDeCarrito.Click += new System.EventHandler(this.btnQuitarDeCarrito_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRealizarCompra,
            this.tsmiCancelarCompra});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiRealizarCompra
            // 
            this.tsmiRealizarCompra.Name = "tsmiRealizarCompra";
            this.tsmiRealizarCompra.Size = new System.Drawing.Size(133, 24);
            this.tsmiRealizarCompra.Text = "Realizar Compra";
            this.tsmiRealizarCompra.Click += new System.EventHandler(this.tsmiRealizarCompra_Click);
            // 
            // tsmiCancelarCompra
            // 
            this.tsmiCancelarCompra.Name = "tsmiCancelarCompra";
            this.tsmiCancelarCompra.Size = new System.Drawing.Size(137, 24);
            this.tsmiCancelarCompra.Text = "Cancelar Compra";
            this.tsmiCancelarCompra.Click += new System.EventHandler(this.tsmiCancelarCompra_Click);
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lblCarrito.Location = new System.Drawing.Point(12, 66);
            this.lblCarrito.MinimumSize = new System.Drawing.Size(348, 0);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(348, 26);
            this.lblCarrito.TabIndex = 5;
            this.lblCarrito.Text = "Carrito";
            this.lblCarrito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lblProductos.Location = new System.Drawing.Point(509, 66);
            this.lblProductos.MinimumSize = new System.Drawing.Size(348, 0);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(348, 26);
            this.lblProductos.TabIndex = 6;
            this.lblProductos.Text = "Productos";
            this.lblProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(366, 250);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(137, 22);
            this.txtCantidad.TabIndex = 7;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(366, 230);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 17);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad";
            // 
            // FrmComprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 564);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.lblCarrito);
            this.Controls.Add(this.btnQuitarDeCarrito);
            this.Controls.Add(this.btnAgregarACarrito);
            this.Controls.Add(this.lbProductos);
            this.Controls.Add(this.lbCarrito);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmComprar";
            this.Text = "FrmComprar";
            this.Load += new System.EventHandler(this.FrmComprar_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCarrito;
        private System.Windows.Forms.ListBox lbProductos;
        private System.Windows.Forms.Button btnAgregarACarrito;
        private System.Windows.Forms.Button btnQuitarDeCarrito;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiRealizarCompra;
        private System.Windows.Forms.Label lblCarrito;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancelarCompra;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
    }
}