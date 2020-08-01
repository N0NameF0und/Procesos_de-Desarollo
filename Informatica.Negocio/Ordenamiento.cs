using System;
using System.Collections.Generic;
using System.Text;

namespace Informatica.Negocio
{
    public class Ordenamiento
    {
        public List<int> Ordenar(int primero, int segundo, int tercero)
        {

            var resultado = new List<int>();

            //Comparador comparador = new Comparador();

            if (primero <= segundo)
            {

                if (primero <= tercero)
                {
                    resultado.Add(primero);

                    if (segundo <= tercero)
                    {
                        resultado.Add(segundo);
                        resultado.Add(tercero);
                    }
                    else
                    {
                        resultado.Add(tercero);
                        resultado.Add(segundo);
                    }
                }
                else
                {
                    resultado.Add(tercero);
                    resultado.Add(primero);
                    resultado.Add(segundo);
                }

            }
            else

            {
                if (segundo <= tercero)
                {
                    resultado.Add(segundo);

                    if (tercero <= primero)
                    {
                        resultado.Add(tercero);
                        resultado.Add(primero);
                    }
                    else
                    {
                        resultado.Add(primero);
                        resultado.Add(tercero);
                    }
                }
                else
                {
                    resultado.Add(tercero);
                    resultado.Add(segundo);
                    resultado.Add(primero);
                }
            }



               /* 
            Menor
                    var menor = comparador.ObtenerMenor(primero, segundo);
            menor = comparador.ObtenerMenor(menor, tercero); 
            resultado.Add(menor);

            Mayor
            var mayor = comparador.ObtenerMayor(primero, segundo); 
            mayor = comparador.ObtenerMayor(mayor, tercero);
            if (segundo != menor && segundo != mayor) resultado.Add(segundo);
            else         
                resultado.Add(mayor);
                */


            //Resultado
            return resultado;
        }

        /*
             public List<Estudiante> OrdenarStrings(Estudiante personal, Estudiante persona2, Estudiante persona3)
            {
                var resultados = new List<String>();
                resultados.Add(personal);
                resultados.Add(persona2);
                resultados.Add(per); 
                resultados.Sort();

                return "" ;

            }
             */


            //Ordenamiento personas
        public List<Persona> Ordenar(Persona primero , Persona segundo , Persona tercero)
        {

            List<Persona> personas = new List<Persona> { primero, segundo, tercero };
            personas.Sort();
            return personas;

        }


    }
}
