using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Persona
    {
        public Persona()
        {

        }

        public Persona(string Nombre, string Apellidos, string Cedula)
        {
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Cedula = Cedula;
        }

        public override string ToString()
        {
            return $"{Nombre};{Apellidos};{Cedula}";
        }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Cedula { get; set; }
    }
}