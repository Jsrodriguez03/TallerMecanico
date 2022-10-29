using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Carro : Vehiculo
    {
        public Carro()
        {

        }

        public Carro(string Marca, string Modelo, string Color, string Servicio, float Precio, string Placa) : base(Marca, Modelo, Color, Servicio, Precio)
        {
            this.Placa = Placa;
        }

        public override string ToString()
        {
            return $"{Marca};{Modelo};{Color};{Servicio};{Precio};{Placa}";
        }

        public string Placa { get; set; }
    }
}