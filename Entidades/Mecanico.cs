using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Mecanico : Persona
    {
        public Mecanico()
        {

        }

        public Mecanico(string Nombre, string Apellidos, string Cedula, string Cargo, string Contraseña):base(Nombre, Apellidos, Cedula)
        {
            this.Cargo = Cargo;
            this.Contraseña = Contraseña;
        }

        public override string ToString()
        {
            return $"{Nombre};{Apellidos};{Cedula};{Cargo};{Contraseña}";
        }

        public string Cargo { get; set; }

        public string Contraseña { get; set; }

        public void VerificarLogin()
        {
            throw new System.NotImplementedException();
        }
    }
}