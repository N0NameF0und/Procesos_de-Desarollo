using System;
using System.Collections.Generic;
using System.Text;

namespace Informatica.Negocio
{
    class QuickSort
    {

        int h;
        int[] vector;
        private void mostrar()
        {
            Console.WriteLine("\nVector ordenados en forma ascendente");
            for (int i = 0; i < h; i++)
            {
                Console.Write("\nValor= " + vector[i]);
            }
            Console.ReadLine();
        }
        public void llenar(int n)
        {
            h = n;
            vector = new int[h];
            Random r = new Random();
            for (int i = 0; i < h; i++)
            {
                vector[i] = r.Next(0, 3000);
                Console.Write("\nValor random= " + vector[i]);
            }
            Sort(vector, 0, h - 1);
            mostrar();
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Quick Sort");
            Console.Write("Cuantos longitud del vector: ");
            n = Int32.Parse(Console.ReadLine());
            QuickSort h = new QuickSort();
            h.llenar(n);
            h.mostrar();
            Console.ReadKey();

        }
        public void Sort(int[] vec, int izq, int der)
        {
            int i, j, pivote, aux;
            i = izq;
            j = der;
            pivote = vec[(izq + der) / 2];
            do
            {
                while (vec[i] < pivote && i < der)
                {
                    i++;
                }
                while (vec[j] > pivote && j > izq)
                {
                    j--;
                }
                if (i <= j)
                {
                    aux = vec[i];
                    vec[i] = vec[j];
                    vec[j] = aux;
                    i++;
                    j--;
                }
            } while (i <= j);
            if (izq < j)
                Sort(vec, izq, j);
            if (i < der)
                Sort(vec, i, der);
        }
    }
}
