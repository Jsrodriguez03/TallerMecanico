using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Bicicleta : Vehiculo
    {
        public Bicicleta()
        {

        }

        public Bicicleta(string Marca, string Modelo, string Color, string Servicio, float Precio):base(Marca, Modelo, Color, Servicio, Precio)
        {

        }

        public override string ToString()
        {
            return $"{Marca};{Modelo};{Color};{Servicio};{Precio}";
        }
    }
}