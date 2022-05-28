using System;
using System.Collections.Generic;

namespace LabNet2022.TP1
{
    public class Menu
    {
        public static void ImprimirMenu(List<TransportePublico> lista)
        {
            Console.Clear();
            Console.WriteLine("*******************************************");
            Console.WriteLine("*       CONTROL DE TRANSPORTE URBANO      *");
            Console.WriteLine("*            Transporte público           *");
            Console.WriteLine("*******************************************");
            Console.WriteLine("");
            Console.WriteLine("********** MENU DE OPCIONES ***********");
            Console.WriteLine("***************************************");
            Console.WriteLine("");
            Console.WriteLine("Selecciones la opción deseada");
            Console.WriteLine("1) - Ingresar la información de los transportes");
            Console.WriteLine("2) - Ver cantidad de pasajeros");
            Console.WriteLine("3) - Salir de la aplicación");
            int seleccion = Funciones.ingresoNumero("Ingrese su selección: ");
            while (seleccion != 3)
            {
                switch (seleccion)
                {
                    case 1: Funciones.CargarDatos(lista); Console.Write("Presione cualquier tecla para continuar: "); Console.ReadKey(); break;
                    case 2: Funciones.ImpimirDatos(lista); Console.Write("Presione cualquier tecla para continuar: "); Console.ReadKey(); break;
                    default: Console.WriteLine("Opcion invalida"); break;
                }
                Console.Clear();
                Console.WriteLine("*******************************************");
                Console.WriteLine("*       CONTROL DE TRANSPORTE URBANO      *");
                Console.WriteLine("*            Transporte público           *");
                Console.WriteLine("*******************************************");
                Console.WriteLine("");
                Console.WriteLine("********** MENU DE OPCIONES ***********");
                Console.WriteLine("***************************************");
                Console.WriteLine("");
                Console.WriteLine("Selecciones la opción deseada");
                Console.WriteLine("1) - Ingresar la información de los transportes");
                Console.WriteLine("2) - Ver cantidad de pasajeros");
                Console.WriteLine("3) - Salir de la aplicación");
                seleccion = Funciones.ingresoNumero("Ingrese su selección: ");
            }
        }


    }
}