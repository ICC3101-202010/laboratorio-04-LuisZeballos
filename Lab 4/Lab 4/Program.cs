using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int a = random.Next(10, 50);
            Console.WriteLine("Numero de piezas a trabajar hoy: " + a);

            ComputadoraCentral computadora = new ComputadoraCentral();

            computadora.Inicio();

            computadora.Trabajar(a);

            computadora.Cierre();

            Console.ReadLine();
        }
    }
}
