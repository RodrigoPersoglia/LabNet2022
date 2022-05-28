using System;

namespace LabNet2022.TP1
{
    public class Taxi : TransportePublico
    {
        public int BajadaBandera { get; set; }

        public Taxi(int pasajeros, int bajadaBandera) : base(pasajeros)
        {
            BajadaBandera = bajadaBandera;
        }

        public override void Avanzar()
        {
            Console.WriteLine("Avanza el Taxi");
        }

        public override void Detenerse()
        {
            Console.WriteLine("Se detiene el Taxi");
        }

    }
}
