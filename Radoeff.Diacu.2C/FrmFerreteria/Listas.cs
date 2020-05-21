using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace FrmFerreteria
{
    public static class Listas
    {
        public static List<Producto> listaProductos { get; set; } = new List<Producto>();
        public static List<Producto> listaCarrito { get; set; } = new List<Producto>();

    }
}
