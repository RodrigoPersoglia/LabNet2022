namespace LabNet2022.TP1
{
    public class Omnibus : TransportePublico
    {
        public int Capacidad { get; set; }

        public Omnibus(int pasajeros, int capacidad) : base(pasajeros)
        {
            Capacidad = capacidad;
        }

        public override string Avanzar()
        {
            return "Avanza el Omnibus";
        }

        public override string Detenerse()
        {
            return "Se detiene el Omnibus";
        }
    }
}
