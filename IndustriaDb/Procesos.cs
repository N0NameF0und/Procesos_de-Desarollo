using System;

namespace IndustriaDb
{
    public class Procesos
    {
        //Variables
        string nombre;
        int numeroProcesos = 5;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int Suma(int first, int second)
        {
            int sum = first;
            for (int i = 0; i < second; i++)
            {
                sum += 1;
            }
            return sum;
        }

       
    }
}
