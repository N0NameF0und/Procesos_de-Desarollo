using System;

namespace Ejemplo
{
    public class Calculator
    {
       public int FirstNumber { get; set; }
       public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

        public int Add(int primernumero , int segundonumero)
        {
            return primernumero + segundonumero;
        }
    }
}
