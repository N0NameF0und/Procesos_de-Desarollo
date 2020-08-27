using System;
using Cambio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Objeto.Test
{
    [TestClass]
    public class UnitTest1
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {

            get { return testContextInstance; }
            set { testContextInstance = value; }

        }

        [TestMethod]
        //[DataSource("System.Data.SqlClient12", @"Data Source=dataDriven;Initial Catalog=results;Persist Security Info=True;User ID=sa;Password=12345;Pooling=False", "test1", DataAccessMethod.Sequential)]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
          @".\data\index.csv", "index#csv", DataAccessMethod.Sequential)]
        public void Añadir()
        {

            ObjetosXD objeto = new ObjetosXD();

            var nombre = Convert.ToString(TestContext.DataRow["Nombre"]);
            var numero = Convert.ToString(TestContext.DataRow["numero"]);
            var fecha = Convert.ToString(TestContext.DataRow["fecha"]);
            var esperado = "Kevin2454502/02/2000";
            var actual = objeto.concatenar(nombre, numero, fecha);

            Assert.AreEqual(esperado, actual);


        }
    }
}
