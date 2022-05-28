namespace LabNet2022.TP1
{
    public class Taxi : TransportePublico
    {
        public int BajadaBandera { get; set; }

        public Taxi(int pasajeros, int bajadaBandera) : base(pasajeros)
        {
            BajadaBandera = bajadaBandera;
        }

        public override string Avanzar()
        {
            return "Avanza el Taxi";
        }

        public override string Detenerse()
        {
            return "Se detiene el Taxi";
        }

    }
}
