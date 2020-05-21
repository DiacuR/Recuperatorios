using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Tienda
    {
        private static List<Pedido> historialDePedidos;
        private static Inventario inventario;

        static Tienda()
        {
            historialDePedidos = new List<Pedido>();
            inventario = new Inventario(100);
        }

        public static Inventario Inventario
        {
            get
            {
                return inventario;
            }
        }


        public static string HistorialDePedidos()
        {
            StringBuilder sb = new StringBuilder();
            if (historialDePedidos != null)
            {
                foreach (Pedido item in historialDePedidos)
                {
                    sb.AppendLine(Pedido.MostrarPedido(item));
                }
            }
            return sb.ToString();
        }
        public static Pedido RealizarPedido(Pedido pedido, List<Producto> productos)
        {
            foreach (Producto item in productos)
            {
                if(!CargarProductoAPedido(pedido,item))
                {
                    pedido = null;
                }
            }
            
            if(pedido != null)
            {
                historialDePedidos.Add(pedido);
            }
            
            return pedido;
        }

        public static bool CargarProductoAPedido(Pedido pedido, Producto producto)
        {
            bool retorno = false;

            foreach (Producto item in Tienda.inventario.Productos)
            {
                if(item == producto)
                {
                    pedido.Productos.Add(producto);
                    retorno = true;
                    break;
                    
                }
            }
            return retorno;
        }
    }
}
