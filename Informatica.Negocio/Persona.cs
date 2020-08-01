using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Informatica.Negocio
{
    public class Persona : IComparable<Persona>
    {

        private string nombre;
        private string apellido;

        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        //Atributes


        internal string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public DateTime Nacimiento { get; internal set; }

        //Methods
        public int CompareTo([AllowNull] Persona other)
        {
            return Apellido.CompareTo(other.Apellido);
        }


    }
}
