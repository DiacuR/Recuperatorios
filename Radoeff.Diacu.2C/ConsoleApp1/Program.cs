using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool pudo;
            Sierra s1 = new Sierra("sierra", 14.50, ECategoria.Sierras, EAmbito.Hogar, ENivelDeExp.Experto, 5,15,Sierra.EMaterialQueCorta.Madera);
            Sierra s2 = new Sierra("sierra electrica", 50.05, ECategoria.Sierras, EAmbito.Profecional, ENivelDeExp.Principiante, 15, 35, Sierra.EMaterialQueCorta.Metal);

            Lampara l1 = new Lampara("Lampara de tubo", 15.50, ECategoria.Lamparas, EAmbito.Profecional, ENivelDeExp.Principiante, 5, 220, Lampara.EColorLampara.Frio);
            Lampara l2 = new Lampara("Lampara de tubo", 50.50, ECategoria.Lamparas, EAmbito.Profecional, ENivelDeExp.Principiante, 10, 220, Lampara.EColorLampara.Calido);

            Inventario inventario = new Inventario(30);

            pudo = inventario + s1;
            if (pudo)
            {
                Console.WriteLine("Exitooooooooooo");
            }
            pudo = inventario + s2;
            if (pudo)
            {
                Console.WriteLine("Exitooooooooooo");
            }
            pudo = inventario + l1;
            if (pudo)
            {
                Console.WriteLine("Exitooooooooooo");
            }


            Console.WriteLine("\nEliminar\n");

            pudo = inventario - l2;

            if (pudo)
            {
                Console.WriteLine("Exitooooooooooo");
            }


            Console.WriteLine(inventario.MostrarInventario());
            Console.ReadKey();

        }
    }
}
