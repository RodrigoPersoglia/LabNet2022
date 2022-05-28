namespace LabNet2022.TP1
{
    public abstract class TransportePublico
    {
        private int _pasajeros;
        public abstract string Avanzar();
        public abstract string Detenerse();

        public TransportePublico(int pasajeros)
        {
            _pasajeros = pasajeros;
        }

        public int Pasajeros
        {
            get => _pasajeros;
        }
    }
}
