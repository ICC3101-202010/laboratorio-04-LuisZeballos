﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Ensamblaje : Maquinas, IWork
    {
        private int Memory;

        public Ensamblaje()
        {
            Random random = new Random();
            int a = random.Next(10, 50);
            this.Memory = a;
        }
        public override void Encendido()
        {
            Console.WriteLine("Fase 3 ensamblaje iniciada");
        }
        public override void Reinicio()
        {
            Random random = new Random();
            int a = random.Next(10, 50);
            this.Memory += a;
        }
        public override void Apagado()
        {
            Console.WriteLine("Fase 3 ensamblaje terminada");
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