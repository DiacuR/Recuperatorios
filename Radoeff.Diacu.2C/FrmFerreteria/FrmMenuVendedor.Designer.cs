namespace FrmFerreteria
{
    partial class FrmMenuVendedor
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
            this.listarStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lamparaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sierraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarStockToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoMasVendidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoMasRentableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoConMasStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Text = "Modo Vendedor";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarStockToolStripMenuItem,
            this.listarStockToolStripMenuItem1,
            this.facturacionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(11, 144);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(480, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listarStockToolStripMenuItem
            // 
            this.listarStockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pinturaToolStripMenuItem,
            this.lamparaToolStripMenuItem,
            this.sierraToolStripMenuItem});
            this.listarStockToolStripMenuItem.Name = "listarStockToolStripMenuItem";
            this.listarStockToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.listarStockToolStripMenuItem.Text = "Agregar Producto";
            // 
            // pinturaToolStripMenuItem
            // 
            this.pinturaToolStripMenuItem.Name = "pinturaToolStripMenuItem";
            this.pinturaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pinturaToolStripMenuItem.Text = "Pintura";
            this.pinturaToolStripMenuItem.Click += new System.EventHandler(this.pinturaToolStripMenuItem_Click);
            // 
            // lamparaToolStripMenuItem
            // 
            this.lamparaToolStripMenuItem.Name = "lamparaToolStripMenuItem";
            this.lamparaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lamparaToolStripMenuItem.Text = "Lampara";
            // 
            // sierraToolStripMenuItem
            // 
            this.sierraToolStripMenuItem.Name = "sierraToolStripMenuItem";
            this.sierraToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sierraToolStripMenuItem.Text = "Sierra";
            // 
            // listarStockToolStripMenuItem1
            // 
            this.listarStockToolStripMenuItem1.Name = "listarStockToolStripMenuItem1";
            this.listarStockToolStripMenuItem1.Size = new System.Drawing.Size(96, 24);
            this.listarStockToolStripMenuItem1.Text = "Listar stock";
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoMasVendidoToolStripMenuItem,
            this.productoMasRentableToolStripMenuItem,
            this.productoConMasStockToolStripMenuItem,
            this.facturacionTotalToolStripMenuItem});
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.facturacionToolStripMenuItem.Text = "Opciones";
            // 
            // productoMasVendidoToolStripMenuItem
            // 
            this.productoMasVendidoToolStripMenuItem.Name = "productoMasVendidoToolStripMenuItem";
            this.productoMasVendidoToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.productoMasVendidoToolStripMenuItem.Text = "Producto mas vendido";
            // 
            // productoMasRentableToolStripMenuItem
            // 
            this.productoMasRentableToolStripMenuItem.Name = "productoMasRentableToolStripMenuItem";
            this.productoMasRentableToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.productoMasRentableToolStripMenuItem.Text = "Producto mas rentable";
            // 
            // productoConMasStockToolStripMenuItem
            // 
            this.productoConMasStockToolStripMenuItem.Name = "productoConMasStockToolStripMenuItem";
            this.productoConMasStockToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.productoConMasStockToolStripMenuItem.Text = "Producto con mas stock";
            // 
            // facturacionTotalToolStripMenuItem
            // 
            this.facturacionTotalToolStripMenuItem.Name = "facturacionTotalToolStripMenuItem";
            this.facturacionTotalToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.facturacionTotalToolStripMenuItem.Text = "Facturacion total";
            // 
            // FrmMenuVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 476);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenuVendedor";
            this.Text = "FrmMenuVendedor";
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.lblBienvenida, 0);
            this.Controls.SetChildIndex(this.lbMostrar, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listarStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarStockToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoMasVendidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoMasRentableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoConMasStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionTotalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pinturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lamparaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sierraToolStripMenuItem;
    }
}