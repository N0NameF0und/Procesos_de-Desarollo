using Rutas;
using System;
using TechTalk.SpecFlow;

namespace RutaCiclopaseo.Steps
{
    [Binding]
    public class RutaSteps
    {
        Bicicleta bici = new Bicicleta();

        [Given(@"que se recorro a una velocidad media de (.*) KM/HORA")]
        public void DadoQueSeRecorroAUnaVelocidadMediaDeKMHORA(int p0)
        {
            bici.velocidad = p0;
        }
        
        [Given(@"existe una distancia media entre puntos de (.*) KM")]
        public void DadoExisteUnaDistanciaMediaEntrePuntosDeKM(int p0)
        {
            bici.distancia = p0;
        }
        
        [Then(@"mi tiempo seria de (.*) HORAS")]
        public bool EntoncesMiTiempoSeriaDeHORAS(int p0)
        {
            var resultado = bici.distancia == p0 ? true : false;
            return resultado;
        }
    }
}
