using System;
using System.Collections.Generic;

namespace LabNet2022.TP1
{
    public class Funciones
    {
        public static int ingresoNumero(string texto)
        {
            Console.Write(texto);
            var ingreso = Console.ReadLine();
            while (!int.TryParse(ingreso, out _))
            {
                Console.WriteLine("El valor ingresado es incorrecto. Reintente");
                Console.Write(texto);
                ingreso = Console.ReadLine();
            }
            return int.Parse(ingreso);
        }

        public static List<TransportePublico> CargarDatos(List<TransportePublico> lista)
        {
            lista.Clear();
            for (int x = 1; x < 11; x++)
            {
                if (x < 6) { Console.WriteLine($"Ingrese los datos del Omnibus n° {x}"); lista.Add(FactoryTransportePublico.CrearTransporte(1)); }
                else { Console.WriteLine($"Ingrese los datos del Taxi n° {x - 5}"); lista.Add(FactoryTransportePublico.CrearTransporte(2)); }
            }
            return lista;
        }

        public static void ImpimirDatos(List<TransportePublico> lista)
        {
            int contador = 1;
            foreach (var transporte in lista)
            {
                if (contador > 5) { contador = 1; }
                Console.WriteLine($"El {transporte.GetType().Name} N° {contador} tiene {transporte.Pasajeros} pasajeros a bordo");
                contador++;
            }
        }

    }
}
