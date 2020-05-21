using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FrmFerreteria
{
    public partial class FrmMenuComprador : FrmMenuPrincipal
    {
        private string nombre;
        public FrmMenuComprador(string nombre)
        {
            InitializeComponent();
            this.nombre = nombre; 
        }

        private void FrmMenuComprador_Load(object sender, EventArgs e)
        {
            this.cmbAmbito.DataSource = Enum.GetValues(typeof(EAmbito));
            this.lblBienvenida.Text = "Bienvenido/a " + nombre; 
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            EAmbito tipo; 
            Enum.TryParse<EAmbito>(this.cmbAmbito.SelectedValue.ToString(), out tipo);
            this.lbMostrar.Items.Clear();

            foreach (Producto item in Tienda.Inventario.Productos)
            {
                if(item.Nombre.Equals(this.txtNombre.Text,StringComparison.OrdinalIgnoreCase) && item.Ambito == tipo)
                {
                    this.lbMostrar.Items.Add(item.ToString());
                }
            }
        }

        private void tsmiComprar_Click(object sender, EventArgs e)
        {
            FrmComprar comprar = new FrmComprar(this.nombre);
            this.Hide();
            comprar.ShowDialog();
            this.Show();
        }
        
        private void tsmiMostrarTodosLosProductos_Click(object sender, EventArgs e)
        {
            this.lbMostrar.Items.Clear();
            foreach (Producto item in Tienda.Inventario.Productos)
            {
                this.lbMostrar.Items.Add(item.ToString());
                this.lbMostrar.Items.Add(item.InstruccionesDeUso());
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
