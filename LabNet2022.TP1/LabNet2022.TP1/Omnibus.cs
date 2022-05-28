using System;

namespace LabNet2022.TP1
{
    public class Omnibus : TransportePublico
    {
        public int Capacidad { get; set; }

        public Omnibus(int pasajeros, int capacidad) : base(pasajeros)
        {
            Capacidad = capacidad;
        }

        public override void Avanzar()
        {
            Console.WriteLine("Avanza el Omnibus");
        }

        public override void Detenerse()
        {
            Console.WriteLine("Se detiene el Omnibus");
        }
    }
}
