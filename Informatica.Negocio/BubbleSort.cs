using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Informatica.Negocio
{
    public class BubbleSort
    {

        public string Bubble(Object objeto)
        {
            
            //obtiene el typo
            var entradaTipo = objeto.GetType().ToString();
            
            //Valores aceptados
            string[] aceptados = {
                "System.Double[]" ,
                "System.Single[]",
                "System.Int32",
                "System.Double"
            };

            //Error en caso de no ser aceptado
            string error = "Tipo no aceptado";


            if ( aceptados.Contains(entradaTipo))
            {
                double[] desordenado = (double[])objeto;
                var resultado = Sort(desordenado); 
                return resultado;
            }
            

            return error;
        }
    




    //metodo de ordenacion burbuja
    private static Array Sort<T>(T[] entrada)
        where T : IComparable<T>
        {
            //fors anidados
            for (int i = 0; i < entrada.Length; i++)
            {
                for (int j = 0; j < entrada.Length - 1; j++)
                {
                    //si el de la izquierda es mayor intercambia
                    if (entrada[j].CompareTo(entrada[j + 1]) > 0)
                    {
                        //intercambia
                        var temp = entrada[j + 1];
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
