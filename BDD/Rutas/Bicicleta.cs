using System;
using System.Collections.Generic;

namespace Rutas
{
    public class Bicicleta
    {
        public int velocidad { get; set; }
        public int distancia { get; set; }

        public int Tiempo()
        {
            int tiempo = this.distancia / this.velocidad;
            return tiempo;
        }

       
    }
}
