using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Recepcion : Maquinas, IWork
    {
        private int Memory;
        public Recepcion()
        {
            Random random = new Random();
            int a = random.Next(10, 50);
            this.Memory = a;
        }
        public override void Encendido()
        {
            Console.WriteLine("Fase 1 recepción iniciada");
        }
        public override void Reinicio()
        {
            this.Memory += 20;
        }
        public override void Apagado()
        {
            Console.WriteLine("Fase 1 recepción terminada");
        }
        public void work()
        {
            Memory-=1;
        }
        public int GetMemory()
        {
            return Memory;
        }
    }

}
