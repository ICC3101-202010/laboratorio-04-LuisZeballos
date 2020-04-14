using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Almacenamiento : Maquinas, IWork
    {
        private int Memory;
        public Almacenamiento()
        {
            Random random = new Random();
            int a = random.Next(10, 50);
            this.Memory = a;
        }
        public override void Encendido()
        {
            Console.WriteLine("Fase 2 almacenamiento iniciada"); 
        }
        public override void Reinicio()
        {
            Random random = new Random();
            int a = random.Next(10, 50);
            this.Memory += a;
        }
        public override void Apagado()
        {
            Console.WriteLine("Fase 2 almacenamiento terminada");
        }
        public void work()
        {
            Memory -= 1;
        }
        public int GetMemory()
        {
            return Memory;
        }

    }
}
