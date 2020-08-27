using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading; 

namespace Carrera
{
    class Program
    {
        static void Main(string[] args)
        {
            Program carrera = new Program();
            carrera.InicioCaminos();
        }

        public void InicioCaminos()
        {
            // un treath dentro de otro treath ?
            Thread[] participantes =
            {
                new Thread(new ThreadStart(Correr)),
                new Thread(new ThreadStart(Correr)),
                new Thread(new ThreadStart(Correr)),
                new Thread(new ThreadStart(Correr)),
                new Thread(new ThreadStart(Correr)),
                new Thread(new ThreadStart(Correr)),
                new Thread(new ThreadStart(Correr)),
                new Thread(new ThreadStart(Correr))
            };

            int counter = 0;

            foreach (Thread jugador in participantes)
            {
                jugador.IsBackground = true;
                jugador.Start();
                counter++;
                jugador.Name = String.Format("Jugador [{0}]", counter);
                Console.WriteLine("Inicio", jugador.Name);
                Thread.Sleep(0);
            }

            
            counter++;

            // ?? 
            // participantes[0].Interrupt();

            // ??
            //      participantes[1].Abort();

            foreach (Thread jugador in participantes)
            {
                jugador.Join();
            }

            Console.WriteLine("Acabo la carrera");
        }

        public void Correr()
        {
            Random rnd = new Random();
            int pasos = rnd.Next(0, 3);
            int total = 0;
        
                while (total != 60)
                {
                    string caminoDescripcion;
                    var total_inicio = total;
                    total += pasos;
                    string ruta = new string('-', (total - total_inicio));
                    caminoDescripcion = String.Concat(ruta);

                Console.WriteLine( caminoDescripcion,
                        Thread.CurrentThread.Name);
                    Thread.Sleep(1);

                }         
        }
    }
}
