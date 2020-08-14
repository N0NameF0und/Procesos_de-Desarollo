using System;
using System.Collections.Generic;
using System.Text;

namespace Informatica.Negocio
{
    class BubbleSort
    {

        static void Main(string[] args)
        {
            // input array
            float[] entrada = { 1, 5, 3, 2, 4 };

            // ejecuta metodo
            float[] resutado = Sort(entrada);


            // imprime valores
            for (int i = 0; i < entrada.Length; i++)
                Console.Write(entrada[i] + " ");

            // pausa en pantalla
            Console.ReadLine();
        }

        //metodo de ordenacion burbuja
        private static float[] Sort(float[] entrada)
        {
            //fors anidados
            for (int i = 0; i < entrada.Length; i++)
            {
                for (int j = 0; j < entrada.Length - 1; j++)
                {
                    //si el de la izquierda es mayor intercambia
                    if (entrada[j] > entrada[j + 1])
                    {
                        //intercambia
                        float temp = entrada[j + 1];
                        entrada[j + 1] = entrada[j];
                        entrada[j] = temp;
                    }
                }
            }

            // devuelve arreglo ordenado
            return entrada;
        }
    }
}
