using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        private string nombre;
        private double precio;
        private ECategoria categoria;
        private EAmbito ambito;
        private ENivelDeExp experiencia;
        private int stock;

        public Producto()
        {

        }
        public Producto(string nombre, double precio, ECategoria categoria, EAmbito ambito, ENivelDeExp experiencia, int stock)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.categoria = categoria;
            this.ambito = ambito;
            this.experiencia = experiencia;
            this.stock = stock;
        }

        public abstract double CalcularMargenGanancias{ get; }
        public double Precio 
        { 
            get
            {
                return this.precio;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                
                this.stock = value;
                
            }
        }

        public EAmbito Ambito
        {
            get
            {
                return this.ambito;
            }
        }

        public ECategoria Categoria
        {
            get
            {
                return this.categoria;
            }
        }

        public ENivelDeExp Experiencia
        {
            get
            {
                return this.experiencia;
            }
        }
        public abstract string InstruccionesDeUso();

        protected double CalcularGanancia(float porcentaje)
        {
            return this.precio + (this.precio * porcentaje);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" " + this.nombre);
            sb.AppendLine("  $" + this.precio);
            sb.AppendLine("  Ambito: " + this.ambito);
            sb.AppendLine("  Usuario Recomendado: " + this.experiencia);
            sb.AppendLine("  Stock: " + this.stock);

            return sb.ToString();
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            return ((p1.Nombre.Equals(p2.Nombre,StringComparison.OrdinalIgnoreCase)) && (p1.ambito == p2.ambito));
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

    }
}
