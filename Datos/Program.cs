using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.IO;

namespace Datos
{
    internal class Program
    {
        public class Archivos
        {
            //List<Familiar> contactos = new List<Familiar>();
            string ruta = "FAMILIARES.TXT";

            public void Guardar(string datos)
            {
                StreamWriter sw = new StreamWriter(ruta, true);
                sw.WriteLine(datos);
                sw.Close();
            }

            public void LeerFamiliares()
            {
                String line;
                try
                {
                    StreamReader sr = new StreamReader(ruta, true);
                    line = sr.ReadLine();
                    int i = 1;

                    while (line != null)
                    {
                        String[] info = line.Split(';');
                        Console.WriteLine($"-------------- Contacto {i} --------------");
                        Console.WriteLine($"ID: {info[0]}");
                        Console.WriteLine($"Nombre: {info[1]}");
                        Console.WriteLine($"Telefono: {info[2]}");
                        Console.WriteLine($"Fecha de Nacimiento: {info[3]}");
                        line = sr.ReadLine();
                        i++;
                        Console.WriteLine("");
                    }
                    sr.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Excepción" + e.Message);
                }

            }

            public void Vaciar()
            {
                StreamWriter sw = new StreamWriter(ruta, false);
                sw.WriteLine("");
                sw.Close();
            }
        }
    }
}
