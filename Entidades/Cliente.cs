using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Cliente : Persona
    {
        public Cliente()
        {

        }

        public Cliente(string Nombre, string Apellidos, string Cedula, string Telefono):base(Nombre, Apellidos, Cedula)
        {
            this.Telefono = Telefono;
        }

        public override string ToString()
        {
            return $"{Nombre};{Apellidos};{Cedula};{Telefono}";
        }

        private string Telefono { get; set; }
    }
}