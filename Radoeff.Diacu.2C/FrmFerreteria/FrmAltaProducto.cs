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
    public partial class FrmAltaProducto : Form
    {
        public FrmAltaProducto()
        {
            InitializeComponent();
        }

        private void FrmAltaProducto_Load(object sender, EventArgs e)
        {
            this.cmbExperiencia.DataSource = Enum.GetValues(typeof(ENivelDeExp));
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            int precio;
            
            Validaciones.ValidarString(this.txtNombre, this.lblNombre.Text);
            Validaciones.ValidarStringNumerico(this.txtPrecio, this.lblPrecio.Text, out precio);
            Validaciones.ValidarStringNumerico(this.txtPrecio, this.lblPrecio.Text, out precio);
        }
    }
}
