using System;
using System.Threading;

namespace Hilos
{
    class ProgramThread
    {

        public static void procesoHilo(object id)
        {
            int identificador = (int)id;

            for (int i = 0; i<100; i++)
            {
                Console.WriteLine($"Proceso de Hilo identificador {id}, con iteracion {i}");
                //Indica el tiempo en que el hilo se detiene
                Thread.Sleep(0);
            }
          
        }

        public static void Main()
        {
            Console.WriteLine("Hilo principal inicio otro hilo ");

            Thread[] caminos = new Thread[1000];
            //creamos una variable del tipo hilo que llama aun procesod para 
            //ejecutarse paralelamente en otro camino

            for (int i = 0; i < 1000; i++)
            {
                caminos[i] = new Thread(procesoHilo) ;
                caminos[i].Start(0);
            }

            //Thread t = new Thread(new ThreadStart(procesoHilo));

            //t.Start();

            for(int i = 0; i< 40; i++)
            {
                Console.WriteLine($"Hilo principal es {i}");
                //Indica al runtime que este hilo va a detenerse entonces el siguiente hilo se va a ejecutar  
                Thread.Sleep(0);
            }

            Console.WriteLine("Hilo principal espera al hilo secundario y unete");
            t.Join();
            Console.WriteLine("El hilo secundario se a unido");
            Console.ReadLine();

        }
    }
}
