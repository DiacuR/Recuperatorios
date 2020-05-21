using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmFerreteria
{
    public partial class FrmMenuVendedor : FrmMenuPrincipal
    {
        public FrmMenuVendedor()
        {
            InitializeComponent();
        }

        private void pinturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaLampara altaLampara = new FrmAltaLampara();
            altaLampara.ShowDialog();
        }
    }
}
