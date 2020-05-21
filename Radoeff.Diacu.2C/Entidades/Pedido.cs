using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        private List<Producto> listaDeProductos;
        private string nombreDelComprador;

        public Pedido()
        {
            this.listaDeProductos = new List<Producto>();
        }

        public Pedido(string nombreDelComprador)
            :this()
        {
            this.nombreDelComprador = nombreDelComprador;
        }

        public List<Producto> Productos
        {
            get { return this.listaDeProductos; }
            // set { this.productos = value; }
        }


        public static string MostrarPedido(Pedido pedido)
        {
            StringBuilder sb = new StringBuilder();
            double precioTotal = 0;

            sb.AppendLine("Pedido: \n");

            foreach (Producto item in pedido.listaDeProductos)
            {
                sb.AppendLine(item.Nombre + "-----" + item.Precio + "Unidades: " + item.Stock);

                precioTotal += item.Precio;
            }

            sb.AppendLine("Precio Total: " + precioTotal);
            sb.AppendLine("Comprador: " + pedido.nombreDelComprador);

            return sb.ToString();
        }


        public static bool operator +(Pedido pedido, Producto producto)
        {
            bool retorno = false;

            if(pedido.listaDeProductos != null)
            {
                pedido.listaDeProductos.Add(producto);
                retorno = true;
            }
            
            return retorno;
        }

        public static bool operator -(Pedido pedido, Producto producto)
        {
            bool retorno = false;

            if(pedido.listaDeProductos.Count > 0)
            {
                pedido.listaDeProductos.Remove(producto);
                retorno = true;
            }

            return retorno;
        }
    }
}
