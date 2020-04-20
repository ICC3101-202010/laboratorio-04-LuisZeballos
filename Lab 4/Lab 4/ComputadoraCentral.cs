using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class ComputadoraCentral
    {
        AdminManual admin = new AdminManual();
        Recepcion recepcion = new Recepcion(20, "recepcion");
        Almacenamiento almacenamiento = new Almacenamiento(15, "almacenamiento");
        Ensamblaje ensamblaje = new Ensamblaje(30, "ensambalje");
        Verificacion verificacion = new Verificacion(25, "verificacion");
        Empaque empaque = new Empaque(40, "empaque");

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
                    if (admin.SeleccionarMaquina("Recepción") == "si")
                    {
                        recepcion.Reinicio();
                    }
                    else
                    {

                        Console.WriteLine("No se puede continuar sin reiniciar, ¿Seguro que desea terminar el proceso antes de tiempo?si/no");
                        string a =Console.ReadLine();
                        if(a == "no")
                        {
                            recepcion.Reinicio();
                            Console.WriteLine("Maquina de Recepcion reiniciada");
                        }
                        else
                        {
                            Console.WriteLine("Se termino el proceso antes de tiempo, se perdieron " + piezas + " piezas");
                            break;
                        }
                    }

                }
                if (almacenamiento.GetMemory() == 0)
                {
                    if (admin.SeleccionarMaquina("Almacenamiento") == "si")
                    {
                        almacenamiento.Reinicio();
                    }
                    else
                    {

                        Console.WriteLine("No se puede continuar sin reiniciar, ¿Seguro que desea terminar el proceso antes de tiempo?si/no");
                        string a = Console.ReadLine();
                        if (a == "no")
                        {
                            almacenamiento.Reinicio();
                            Console.WriteLine("Maquina de Almacenamiento reiniciada");
                        }
                        else
                        {
                            Console.WriteLine("Se termino el proceso antes de tiempo, se perdieron " + piezas + " piezas");
                            break;
                        }
                    }
                }
                if (ensamblaje.GetMemory() == 0)
                {
                    if (admin.SeleccionarMaquina("Ensamblaje") == "si")
                    {
                        ensamblaje.Reinicio();
                    }
                    else
                    {

                        Console.WriteLine("No se puede continuar sin reiniciar, ¿Seguro que desea terminar el proceso antes de tiempo?si/no");
                        string a = Console.ReadLine();
                        if (a == "no")
                        {
                            ensamblaje.Reinicio();
                            Console.WriteLine("Maquina de Ensamblaje reiniciada");
                        }
                        else
                        {
                            Console.WriteLine("Se termino el proceso antes de tiempo, se perdieron " + piezas + " piezas");
                            break;
                        }
                    }
                }
                if (verificacion.GetMemory() == 0)
                {
                    if (admin.SeleccionarMaquina("Verificación") == "si")
                    {
                        verificacion.Reinicio();
                    }
                    else
                    {

                        Console.WriteLine("No se puede continuar sin reiniciar, ¿Seguro que desea terminar el proceso antes de tiempo?si/no");
                        string a = Console.ReadLine();
                        if (a == "no")
                        {
                            verificacion.Reinicio();
                            Console.WriteLine("Maquina de Verificación reiniciada");
                        }
                        else
                        {
                            Console.WriteLine("Se termino el proceso antes de tiempo, se perdieron " + piezas + " piezas");
                            break;
                        }
                    }
                }
                if (empaque.GetMemory() == 0)
                {
                    if (admin.SeleccionarMaquina("Empaque") == "si")
                    {
                        empaque.Reinicio();
                    }
                    else
                    {

                        Console.WriteLine("No se puede continuar sin reiniciar, ¿Seguro que desea terminar el proceso antes de tiempo?si/no");
                        string a = Console.ReadLine();
                        if (a == "no")
                        {
                            empaque.Reinicio();
                            Console.WriteLine("Maquina de Empaque reiniciada");
                        }
                        else
                        {
                            Console.WriteLine("Se termino el proceso antes de tiempo, se perdieron " + piezas + " piezas");
                            break;
                        }
                    }
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
