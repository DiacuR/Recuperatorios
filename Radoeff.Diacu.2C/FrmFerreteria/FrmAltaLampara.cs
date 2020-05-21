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
    public partial class FrmAltaLampara : FrmAltaProducto
    {
        public FrmAltaLampara()
        {
            InitializeComponent();
        }

        private void FrmAltaLampara_Load(object sender, EventArgs e)
        {
            this.cmbAmbito.DataSource = Enum.GetValues(typeof(EAmbito));
            this.cmbColor.DataSource = Enum.GetValues(typeof(Lampara.EColorLampara));
        }


    }
}
