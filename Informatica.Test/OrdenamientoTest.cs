using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using CollectionAssert = Microsoft.VisualStudio.TestTools.UnitTesting.CollectionAssert;

namespace Informatica.Negocio.Test
{
    [TestClass]
    public class OrdenamientoTest
    {
        [TestMethod]
        public void TresElementosPositivos() {

            //Variables de pruebas
            var primero = 45;
            var segundo = 23;
            var tercero = 15;


            //Variables de resultado 1
            var esperado0 = 15;
            var esperado1 = 23;


            //Procesamiento       
        Ordenamiento ordenamiento = new Ordenamiento();
        List<int> esperados = ordenamiento.Ordenar(primero, segundo, tercero);



            //Test
        Assert.AreEqual(esperado0, esperados[0]);
        Assert.AreEqual(esperado1, esperados[1]); 

            }

    [TestMethod]
    public void PruebaAbc()
    {

        //Variables de pruebas
        var primero = 45;
        var segundo = 23;
        var tercero = 15;


        //Variables de resultado 1
        var esperado0 = 15;
        var esperado1 = 23;
        var esperado2 = 45;
            int[] resultados = { esperado0,esperado1,esperado2};


            //Procesamiento       
            Ordenamiento ordenamiento = new Ordenamiento();
        List<int> esperados = ordenamiento.Ordenar(primero, segundo, tercero);



            //Test
            CollectionAssert.AreEqual(resultados, esperados);
            CollectionAssert.AreEqual(resultados, esperados);

    }

        [TestMethod]
        public void PruebaBca()
        {

            //Variables de pruebas
            var primero = 15;
            var segundo = 45;
            var tercero = 30;


            //Variables de resultado 1
            var esperado0 = 15;
            var esperado1 = 30;
            var esperado2 = 45;
            int[] resultados = { esperado0, esperado1, esperado2 };


            //Procesamiento       
            Ordenamiento ordenamiento = new Ordenamiento();
            List<int> esperados = ordenamiento.Ordenar(primero, segundo, tercero);



            //Test
            CollectionAssert.AreEqual(resultados, esperados);
            CollectionAssert.AreEqual(resultados, esperados);

        }

        [TestMethod]
        public void PruebaAcb()
        {

            //Variables de pruebas
            var primero = 30;
            var segundo = 45;
            var tercero = 15;


            //Variables de resultado 1
            var esperado0 = 15;
            var esperado1 = 30;
            var esperado2 = 45;
            int[] resultados = { esperado0, esperado1, esperado2 };


            //Procesamiento       
            Ordenamiento ordenamiento = new Ordenamiento();
            List<int> esperados = ordenamiento.Ordenar(primero, segundo, tercero);



            //Test
            CollectionAssert.AreEqual(resultados, esperados);
            CollectionAssert.AreEqual(resultados, esperados);

        }

        [TestMethod]
        public void PruebaCba()
        {

            //Variables de pruebas
            var primero = 45;
            var segundo = 30;
            var tercero = 15;


            //Variables de resultado 1
            var esperado0 = 15;
            var esperado1 = 30;
            var esperado2 = 45;
            int[] resultados = { esperado0, esperado1, esperado2 };


            //Procesamiento       
            Ordenamiento ordenamiento = new Ordenamiento();
            List<int> esperados = ordenamiento.Ordenar(primero, segundo, tercero);



            //Test
            CollectionAssert.AreEqual(resultados, esperados);
            CollectionAssert.AreEqual(resultados, esperados);

        }

           [TestMethod]
        public void PruebaCab()
        {

            //Variables de pruebas
            var primero = 45;
            var segundo = 30;
            var tercero = 15;


            //Variables de resultado 1
            var esperado0 = 15;
            var esperado1 = 30;
            var esperado2 = 45;
            int[] resultados = { esperado0, esperado1, esperado2 };


            //Procesamiento       
            Ordenamiento ordenamiento = new Ordenamiento();
            List<int> esperados = ordenamiento.Ordenar(primero, segundo, tercero);



            //Test
            CollectionAssert.AreEqual(resultados, esperados);
            CollectionAssert.AreEqual(resultados, esperados);

        }

        [TestMethod]
        public void OrdenarPersonas()
        {

            //Variables de pruebas

            var nombre = "Camila"; 
            var apellido = "Morales"; 
            var persona1 = new Persona(nombre, apellido);

            nombre = "Juan";
            apellido = "Lopez";
            var persona2 = new Persona(nombre, apellido);

            nombre = "Lucia";
            apellido = "Armijos";
            var persona3 = new Persona(nombre, apellido);



            //Variables resultado

            var primerApellidoEsperado = "Armijos"; 
            var segundoApellidoEsperado = "Lopez";
            var tercerApellidoEsperado = "Morales";


            //Procesamiento       
            Ordenamiento ordenamiento = new Ordenamiento();
            List<Persona> esperados = ordenamiento.Ordenar(persona1, persona2, persona3);


            //Test

            Assert.AreEqual(primerApellidoEsperado, esperados[0].Apellido);
            Assert.AreEqual(segundoApellidoEsperado, esperados[1].Apellido); 
            Assert.AreEqual(tercerApellidoEsperado, esperados[2].Apellido);


        }

    }


}

