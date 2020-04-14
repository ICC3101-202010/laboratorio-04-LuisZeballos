using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class ComputadoraCentral
    {

        Recepcion recepcion = new Recepcion(20,"recepcion");
        Almacenamiento almacenamiento = new Almacenamiento(15,"almacenamiento");
        Ensamblaje ensamblaje = new Ensamblaje(30,"ensambalje");
        Verificacion verificacion = new Verificacion(25,"verificacion");
        Empaque empaque = new Empaque(40,"empaque");

        List<Maquinas> listi = new List<Maquinas>();
        List<Maquinas> listc = new List<Maquinas>();
 

        public void Inicio()
        {
            listi.Add(recepcion);
            listi.Add(almacenamiento);
            listi.Add(ensamblaje);
            listi.Add(verificacion);
            listi.Add(empaque);
            foreach (Maquinas name in listi)
            {
                name.Encendido();
            }

        }
        public void Trabajar(int piezas)
        {
            while(piezas > 0)
            {
                recepcion.work();
                almacenamiento.work();
                ensamblaje.work();
                verificacion.work();
                empaque.work();
                if (recepcion.GetMemory() == 0)
                {
                    recepcion.Reinicio();
                    Console.WriteLine("La maquina de recepción se reinicio");
                }
                if (almacenamiento.GetMemory() == 0)
                {
                    almacenamiento.Reinicio();
                    Console.WriteLine("La maquina de almacenamiento se reinicio");
                }
                if (ensamblaje.GetMemory() == 0)
                {
                    ensamblaje.Reinicio();
                    Console.WriteLine("La maquina de ensamblaje se reinicio");
                }
                if (verificacion.GetMemory() == 0)
                {
                    verificacion.Reinicio();
                    Console.WriteLine("La maquina de verificación se reinicio");
                }
                if (empaque.GetMemory() == 0)
                {
                    empaque.Reinicio();
                    Console.WriteLine("La maquina de empaque se reinicio");
                }
                piezas -= 1;

            }
        }

        public void Cierre()
        {
            listc.Add(recepcion);
            listc.Add(almacenamiento);
            listc.Add(ensamblaje);
            listc.Add(verificacion);
            listc.Add(empaque);
            foreach (Maquinas name in listc)
            {
                name.Apagado();
            }
        }



    }
}
