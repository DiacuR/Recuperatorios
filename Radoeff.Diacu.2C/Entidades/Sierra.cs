using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sierra : Producto
    {
        private int dientesDeLaHoja;
        private EMaterialQueCorta corta;

        public Sierra()
        {

        }

        public Sierra(string nombre, double precio, EAmbito ambito, ENivelDeExp experiencia, int stock, int dientesDeLaHoja, EMaterialQueCorta corta)
            : base(nombre,precio,ECategoria.Sierras,ambito,experiencia,stock)
        {
            this.dientesDeLaHoja = dientesDeLaHoja;
            this.corta = corta;
        }
        public override double CalcularMargenGanancias
        {
            get
            {
                return CalcularGanancia(0.13f);
            }
        }

        public int CantDeDientes
        {
            get { return this.dientesDeLaHoja; }
        }

        public EMaterialQueCorta MaterialQueCorta
        {
            get { return this.corta; }
        }
        public override string InstruccionesDeUso()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. Se agarra la sierra y se coloca en la superficie a cortar");
            sb.AppendLine("1. Verificar que tipo de sierra es.");
            sb.AppendLine("\t1a. La sierra electricas debe conectar a una fuente de electricidad.");
            sb.AppendLine("\t1b. Se debe verificar que la hoja de la sierra sea indicada para" +
                " el tipo de material que se va cortar\n");
            sb.AppendLine("\t2b. La sierra de mano no necesita conexion");
            sb.AppendLine("2. Se la coloca sobre el material a cortar");
            sb.AppendLine("3. Se empieza a cortar el material");

            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Sierra: \n");
            sb.AppendLine(base.ToString());
            sb.AppendLine("  Cant de dientes: " + this.dientesDeLaHoja);
            sb.AppendLine("  Material que corta: " + this.corta);
            sb.AppendLine("");

            return sb.ToString();
        }
        public enum EMaterialQueCorta
        {
            Madera,
            Metal,
            Hormigon
        }
    }
}
