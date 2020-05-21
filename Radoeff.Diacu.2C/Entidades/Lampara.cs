using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lampara : Producto
    {
        private int consumoElectrico;
        private EColorLampara colorLampara;

        public Lampara()
        {

        }

        public Lampara(string nombre, double precio, EAmbito ambito, ENivelDeExp experiencia, int stock, int consumoElectrico, EColorLampara colorLampara)
            : base(nombre,precio,ECategoria.Lamparas,ambito,experiencia,stock)
        {
            this.consumoElectrico = consumoElectrico;
            this.colorLampara = colorLampara;
        }

        public override double CalcularMargenGanancias
        {
            get
            {
                return CalcularGanancia(0.16f);
            }
        }

        public int ConsumoElectrico
        {
            get { return this.consumoElectrico; }
        }

        public EColorLampara Color
        {
            get { return this.colorLampara; }
        }

        public override string InstruccionesDeUso()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. Se conecta la lampara a una red electrica.");
            sb.AppendLine("2. Despues se deja pasar corriente por esa red.");
            sb.AppendLine("3. Y la lampara se enciende.");

            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lampara: \n ");
            sb.AppendLine(base.ToString());
            sb.AppendLine("  Consumo: " + this.consumoElectrico + "W");
            sb.AppendLine("  Color: " + this.colorLampara);
            sb.AppendLine("");

            return sb.ToString();
        }

        public enum EColorLampara
        {
            Frio,
            Calido
        }
    }
}
