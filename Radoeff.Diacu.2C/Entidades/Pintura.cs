using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pintura : Producto
    {
        private ConsoleColor color;
        private int cantEnLitros;
        private ELugarDeUso lugarDeUso;

        public Pintura()
        {

        }

        public Pintura(string nombre, double precio, EAmbito ambito, ENivelDeExp experiencia, int stock, ConsoleColor color, int cantEnLitros, ELugarDeUso lugarDeUso)
            : base(nombre,precio,ECategoria.Pinturas,ambito,experiencia,stock)
        {
            this.color = color;
            this.cantEnLitros = cantEnLitros;
            this.lugarDeUso = lugarDeUso;
        }

        public override double CalcularMargenGanancias
        {
            get
            {
                return CalcularGanancia(0.1f);
            }
        }

        public ConsoleColor Color { get { return this.color; } }
        public int CantEnLitros { get { return this.cantEnLitros; } }
        public ELugarDeUso LugarDeUso { get { return this.lugarDeUso; } }

        public override string InstruccionesDeUso()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. Mojamos un/a rodillo/brocha en la pintura.");
            sb.AppendLine("2. Hacemos Trazos de arriba a abajo en la superficie a pintar.");

            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tintura: \n");
            sb.AppendLine(base.ToString());
            sb.AppendLine("  Color: " + this.Color);
            sb.AppendLine("  Litros: " + this.CantEnLitros);
            sb.AppendLine("");

            return sb.ToString();
        }

        public enum ELugarDeUso
        {
            Interior,
            Exterior
        }
    }
}
