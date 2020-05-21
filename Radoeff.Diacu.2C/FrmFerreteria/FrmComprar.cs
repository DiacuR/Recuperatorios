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
    public partial class FrmComprar : Form
    {
        private string nombre;
        public FrmComprar(string nombre)
        {
            InitializeComponent();
            this.nombre = nombre;
        }

        private void FrmComprar_Load(object sender, EventArgs e)
        {
            Listas.listaProductos = Tienda.Inventario.Productos;
            CargarInventario();
        }

        private void btnAgregarACarrito_Click(object sender, EventArgs e)
        {
            AgregarAListBox(this.lbProductos,this.lbCarrito, Listas.listaProductos, Listas.listaCarrito);
            CargarInventario();
            CargarCarrito();
        }


        public void AgregarAListBox(ListBox listaPrincipal, ListBox listaSecundaria, List<Producto> prodPrincipales, List<Producto> prodSecundarios)
        {
            Producto producto;
            int cantidad;
            int stockDisponible;
            string descripcionDeProducto;

            if (this.txtCantidad.Text != "")
            {
                if (listaPrincipal.SelectedItem != null && listaPrincipal.Items.Count > 0)
                {
                    descripcionDeProducto = listaPrincipal.SelectedItem.ToString();
                    producto = ObtenerProducto(prodPrincipales, descripcionDeProducto);
                    
                    if (Validaciones.ValidarStringNumerico(this.txtCantidad, this.lblCantidad.Text, out cantidad) && producto.Stock >= cantidad)
                    {
                        stockDisponible = producto.Stock - cantidad;
                        producto.Stock = cantidad;
                        PasarDeInventarioACarrito(listaPrincipal, listaSecundaria, prodPrincipales,prodSecundarios, producto, stockDisponible, cantidad);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error. Tiene que agregar una cantidad.", "Mensaje de Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public Producto ObtenerProducto(List<Producto> productos, string descripcion)
        {
            Producto producto = null;

            foreach (Producto item in productos)
            {
                if (descripcion.Substring(0,53).Equals(item.ToString().Substring(0,53)))
                {
                    producto = item;
                }
            }
            producto = DevolverProductoEspecifico(producto);
            return producto;
        }

        public void PasarDeInventarioACarrito(ListBox listPrincipal, ListBox listSecundaria, List<Producto> prodPrincipales, List<Producto> prodSecundarios, Producto producto, int stockDisponible, int cantidad)
        {
            bool flag = false;
            int index;
            
            foreach (Producto item in prodSecundarios)
            {
                if (item == producto)
                {
                    if (producto.Stock <= stockDisponible)
                    {
                        item.Stock += cantidad;
                        index = listPrincipal.SelectedIndex;
                        producto = DevolverProductoEspecifico(item);
                        producto.Stock = stockDisponible;
                        prodPrincipales.RemoveAt(index);
                        prodPrincipales.Add(producto);
                    }
                    else
                    {
                        MessageBox.Show("Error. No disponemos de esa cantidad de stock", "Mensaje de Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                ComprobarStock(listPrincipal,listSecundaria,prodPrincipales,prodSecundarios, producto, stockDisponible);
            }
        }

        public void ComprobarStock(ListBox listPrincipal, ListBox listSecundaria, List<Producto> prodPrincipales, List<Producto> prodSecundarios,Producto producto, int stockDisponible)
        {
            int index;
            if (stockDisponible > 0)
            {
                prodSecundarios.Add(producto);
                index = listPrincipal.SelectedIndex;
                prodPrincipales.RemoveAt(index);
                producto = DevolverProductoEspecifico(producto);
                producto.Stock = stockDisponible;
                prodPrincipales.Add(producto);
            }
            else if (stockDisponible == 0)
            {
                prodSecundarios.Add(producto);
                index = listPrincipal.SelectedIndex;
                producto = DevolverProductoEspecifico(producto);
                prodPrincipales.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Error. No disponemos de esa cantidad de stock", "Mensaje de Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnQuitarDeCarrito_Click(object sender, EventArgs e)
        {
            AgregarAListBox(this.lbCarrito,this.lbProductos,Listas.listaCarrito,Listas.listaProductos);
            CargarCarrito();
            CargarInventario();
        }

        private void tsmiRealizarCompra_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido(nombre);
            DialogResult dr;
            if (Listas.listaCarrito != null)
            {
                foreach (Producto item in Listas.listaCarrito)
                {
                    if (!Tienda.CargarProductoAPedido(pedido, item))
                    {
                        MessageBox.Show("Error al agregar producto al Carrito", "Mensaje de Error", MessageBoxButtons.OK);
                        pedido = null;
                    }

                }
                dr = MessageBox.Show(Pedido.MostrarPedido(pedido));
                if (dr == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Primero agrege productos al carrito", "Mensaje de Error", MessageBoxButtons.OK);
            }
        }

        public void CargarInventario()
        {
            this.lbProductos.Items.Clear();
            foreach (Producto item in Listas.listaProductos)
            {
                this.lbProductos.Items.Add(item.ToString());
            }
        }

        public void CargarCarrito()
        {
            this.lbCarrito.Items.Clear();
            foreach (Producto item in Listas.listaCarrito)
            {
                this.lbCarrito.Items.Add(item.ToString());
            }
        }

        public Producto DevolverProductoEspecifico(Producto p)
        {
            Producto prodEspecifico = null;
            Lampara lam;
            Sierra sierra;
            Pintura pint;

            if (p is Lampara)
            {
                lam = (Lampara)p;
                prodEspecifico = new Lampara(lam.Nombre, lam.Precio, lam.Ambito, lam.Experiencia, lam.Stock, lam.ConsumoElectrico, lam.Color);
            }
            else if(p is Sierra)
            {
                sierra = (Sierra)p;
                prodEspecifico = new Sierra(sierra.Nombre, sierra.Precio, sierra.Ambito, sierra.Experiencia, sierra.Stock, sierra.CantDeDientes, sierra.MaterialQueCorta);
            }
            else if(p is Pintura)
            {
                pint = (Pintura)p;
                prodEspecifico = new Pintura(pint.Nombre, pint.Precio, pint.Ambito, pint.Experiencia, pint.Stock, pint.Color, pint.CantEnLitros, pint.LugarDeUso);
            }

            return prodEspecifico;
        }

        private void tsmiCancelarCompra_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Seguro que desea salir?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
