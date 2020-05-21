using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Inventario
    {
        private List<Producto> productos;
        private int capacidadInventario;

        public Inventario()
        {
            this.productos = new List<Producto>();
        }
        public Inventario(int capacidadInventario) 
            : this()
        {
            this.capacidadInventario = capacidadInventario;
        }

        public List<Producto> Productos
        {
            get { return this.productos; }
           // set { this.productos = value; }
        }


        private int CapacidadLibre()
        {
            int acumulador = 0;
            for (int i = 0; i < this.productos.Count; i++)
            {
                if (acumulador > this.capacidadInventario)
                {
                    acumulador = this.capacidadInventario;
                }

                acumulador += this.productos[i].Stock;
            }

            return this.capacidadInventario - acumulador;
        }     


        public String MostrarInventario()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Producto item in this.Productos)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        } 

        public static bool operator ==(Inventario inventario, Producto producto)
        {
            bool retorno = false;
            if (inventario.Productos != null)
            {
                foreach (Producto elem in inventario.productos)
                {
                    if (elem == producto && elem.Stock > 0)
                    {
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Inventario inventario, Producto producto)
        {
            return !(inventario == producto);
        }

        public static bool operator +(Inventario inventario, Producto producto)
        {
            bool retorno = false;

            if (inventario == producto)             //Si el producto existe          
            {
                foreach (Producto item in inventario.productos)
                {
                    if (item == producto && inventario.CapacidadLibre() >= producto.Stock)
                    {
                        item.Stock += producto.Stock;
                        retorno = true;
                    }
                }
            }           
            else                                    //Si el producto no existe
            {
                if (inventario.CapacidadLibre() >= producto.Stock)
                {
                    inventario.productos.Add(producto);
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator -(Inventario inventario, Producto producto)
        {
            bool retorno = false;
            int stock;
            if (inventario.Productos != null)
            {
                foreach (Producto item in inventario.productos)
                {
                    if (item == producto)
                    {
                        stock = item.Stock - producto.Stock;
                        if (stock > 0)
                        {
                            item.Stock -= producto.Stock;
                        }
                        else if (stock == 0)
                        {
                            inventario.productos.Remove(item);
                        }
                        else
                        {
                            retorno = false;
                            break;
                        }
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;
        }
    }
}
