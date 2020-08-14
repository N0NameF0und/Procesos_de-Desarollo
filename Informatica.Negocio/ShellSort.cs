using System;
using System.Collections.Generic;
using System.Text;

namespace Informatica.Negocio
{
    class ShellSort
    {
        static void Sort(int[] arr, int n)
        {
            int i, j, pos, temp;
            pos = 3;
            while (pos > 0)
            {
                for (i = 0; i < n; i++)
                {
                    j = i;
                    temp = arr[i];
                    while ((j >= pos) && (arr[j - pos] > temp))
                    {
                        arr[j] = arr[j - pos];
                        j = j - pos;
                    }
                    arr[j] = temp;
                }
                if (pos / 2 != 0)
                    pos = pos / 2;
                else if (pos == 1)
                    pos = 0;
                else
                    pos = 1;
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 56, 12, 99, 32, 1, 95, 25, 5, 100, 84 };
            int n = arr.Length;
            int i;
            Console.WriteLine("Shell Sort");
            Console.Write("Array Inicial: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Sort(arr, n);
            Console.Write("\nArray Ordenado: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
