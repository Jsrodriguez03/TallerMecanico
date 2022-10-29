using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Vehiculo
    {
        public Vehiculo()
        {

        }

        public Vehiculo(string Marca, string Modelo, string Color, string Servicio, float Precio)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Color = Color; 
            this.Servicio = Servicio;
            this.Precio = Precio;
        }

        public override string ToString()
        {
            return $"{Marca};{Modelo};{Color};{Servicio};{Precio}";
        }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Color { get; set; }

        public string Servicio { get; set; }

        public float Precio { get; set; }
    }
}