using Industria;
using IndustriaDb;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Industria.Test
{
    [TestClass]
    public class CalculoTest
    {
        [TestMethod]
        public void RaizCuadrada()
        {
            var operando = 4;
            var esperado = 2;
            var decimales = 3;

            Calculo calculo = new Calculo();
            var actual = calculo.raiz(operando,decimales);

            Assert.AreEqual(esperado,actual);

        }

        [TestMethod]
        public void RaizCuadradaDecimal()
        {
            var operando = 10;
            var esperado = 3.162;
            var decimales = 3;

            Calculo calculos = new Calculo();
            var actual = calculos.raiz(operando,decimales);

            Assert.AreEqual(esperado, actual);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "No se aceptan numeros negativos")]
        public void RaizCuadradaNegativo()
        {
            var operando = -10;
            var esperado = 3.162;
            var decimales = 3;

            Calculo calculos = new Calculo();
            var actual = calculos.raiz(operando, decimales);

            Assert.AreEqual(esperado, actual);

        }


    }
}
