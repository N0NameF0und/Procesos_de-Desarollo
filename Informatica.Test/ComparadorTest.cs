using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Informatica.Negocio.Test
{
    [TestClass]
    public class ComparadorTest
    {

        [TestMethod]
        public void ObtenerMenor ()
        {
            // Triple A a> AAA .> Arrange Act Assert 
             // Organizer los datos --Arrange 
                
            var primerElemento = 56; 
            var segundoElemento = 20; 
            var esperado = 20;


            // Ejecute -- Act Comparalor 

                Comparador comparador = new Comparador();

            int actual = comparador.ObtenerMenor(primerElemento, segundoElemento); 
            
                
                // Comprobar -- Assert 
                
                Assert.AreEqual(esperado, actual); 

        }


    }

}
