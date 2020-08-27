using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using Informatica.Negocio;

namespace Matematica.Tests
{
    [TestClass]
    public class SortingTets
    {
        //variables prueba
        private string palabra = "int";
        private int numero = 1;
        private double numerod = 10.5;
        private float[] numerosf = { 1.45f, 2.454f, 3.54f };
        private double[] numerosd = { 4.4, 5.8 , 954.1};
        private string prueba = "prueba";
        private string[] numerosLetras = { "1", "2", "3" };

        [TestMethod]

        public void BubbleSort()
        {
            
            //Objeto prueba
            BubbleSort bubblesort= new BubbleSort();

            //Operacion prueba
            var respuesta = bubblesort.Bubble(numerosd);

            //Resultado
            Assert.AreEqual(palabra,respuesta);
        }
    }
}
