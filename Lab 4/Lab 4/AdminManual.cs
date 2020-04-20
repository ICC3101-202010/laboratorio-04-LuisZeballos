using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class AdminManual
    {
        public string SeleccionarMaquina(string s)
        {
            Console.WriteLine("La memoria de la máquina " + s + " se lleno y necesita ser reiniciada");
            Console.WriteLine("¿Desea reiniciarla? si/no");
            string a = Console.ReadLine();
            return a;
        }
    }
}
