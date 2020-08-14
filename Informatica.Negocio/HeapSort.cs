using System;
using System.Collections.Generic;
using System.Text;

namespace Informatica.Negocio
{
    class HeapSort
    {
        int[] r = { 2, 5, 1, 10, 6, 9, 3, 7, 4, 8 };
        public void Sort()
        {
            int i, t;
            for (i = 5; i >= 0; i--)
            {
                ajuste(i, 9);
            }
            for (i = 8; i >= 0; i--)
            {
                t = r[i + 1];
                r[i + 1] = r[0];
                r[0] = t;
                ajuste(0, i);
            }
        }
        private void ajuste(int i, int n)
        {
            int t, j;
            try
            {
                t = r[i];
                j = 2 * i;
                while (j <= n)
                {
                    if (j < n && r[j] < r[j + 1])
                        j++;
                    if (t >= r[j])
                        break;
                    r[j / 2] = r[j];
                    j *= 2;
                }
                r[j / 2] = t;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(" Array fuera de limites ", e);
            }
        }
        public void print()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}", r[i]);
            }

        }
        public static void Main()
        {
            HeapSort obj = new HeapSort();
            Console.WriteLine("Array Inicial : ");
            obj.print();
            obj.Sort();
            Console.WriteLine("Array Areglado : ");
            obj.print();
            Console.Read();
        }
    }
}
