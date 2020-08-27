using Ejemplo;
using System;

namespace Financiera
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Calculator calculadora = new Calculator();

            calculadora.FirstNumber = 50;
            calculadora.SecondNumber = 70;

            int resultado = calculadora.Add();
            int resultado2 = calculadora.Add(50,70);


            Console.WriteLine($"LA SUMA DE {calculadora.FirstNumber} y de {calculadora.SecondNumber} es {resultado} ");
            Console.WriteLine($"LA SUMA DE {calculadora.FirstNumber} y de {calculadora.SecondNumber} es {resultado2} ");
        }
    }
}
