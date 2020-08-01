using System;
using System.Collections.Generic;
using System.Text;

namespace Informatica.Negocio
{
    public class Comparador
    {
        public int ObtenerMenor(int primerElemento, int segundoElemento)
        {
            return primerElemento < segundoElemento ? primerElemento : segundoElemento;
        }
        public int ObtenerMayor(int primerElemento, int segundoElemento)
        {
            return primerElemento > segundoElemento ? primerElemento : segundoElemento;
        }
    }
}


