using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Empaque : Maquinas, IWork
    {
        private int Memory;
        private int a;
        public string TipoTrabajo { set; get; }
        public Empaque(int a,string trabajo)
        {
            this.a = a;
            this.Memory = a;
            this.TipoTrabajo = trabajo;
        }
        public override void Encendido()
        {
            Console.WriteLine("Fase 5 empaque iniciada");
        }
        public override void Reinicio()
        {
            this.Memory += a;
        }
        public override void Apagado()
        {
            Console.WriteLine("Fase 5 empaque terminada");
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
