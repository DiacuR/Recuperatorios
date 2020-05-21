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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnComprador_Click(object sender, EventArgs e)
        {
            FrmMenuComprador menuComprador = new FrmMenuComprador(this.txtNombreDeUsuario.Text);
            ValidarLogin(menuComprador);
            
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            FrmMenuVendedor menuVendedor = new FrmMenuVendedor();
            ValidarLogin(menuVendedor);
            
        }

        private void ValidarLogin(FrmMenuPrincipal menu)
        {
            if (Validaciones.ValidarString(this.txtNombreDeUsuario, this.lblNombre.Text))
            {
                if (this.txtContraseña.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese una contraseña", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.Hide();
                    menu.Show();
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            bool puede;
            Lampara l1 = new Lampara("Lampara de Led", 15.50, EAmbito.Profecional, ENivelDeExp.Principiante, 5, 220, Lampara.EColorLampara.Frio);
            Lampara l3 = new Lampara("Lampara de tubo", 15.50, EAmbito.Hogar, ENivelDeExp.Principiante, 5, 220, Lampara.EColorLampara.Frio);
            Lampara l2 = new Lampara("Lampara", 50.50, EAmbito.Profecional, ENivelDeExp.Principiante, 10, 220, Lampara.EColorLampara.Calido);
            Sierra s1 = new Sierra("sierra", 14.50, EAmbito.Hogar, ENivelDeExp.Experto, 5, 15, Sierra.EMaterialQueCorta.Madera);
            Sierra s2 = new Sierra("sierra electrica", 50.05, EAmbito.Profecional, ENivelDeExp.Principiante, 15, 35, Sierra.EMaterialQueCorta.Metal);

            puede = Tienda.Inventario + s1;
            puede = Tienda.Inventario + s2;
            puede = Tienda.Inventario + l1;
            puede = Tienda.Inventario + l2;
            puede = Tienda.Inventario + l3;
        }

        //public bool HardcodearDatos()
        //{

        //}
    }
}
