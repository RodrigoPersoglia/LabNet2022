namespace LabNet2022.TP1
{
    public abstract class TransportePublico
    {
        private int _pasajeros;
        public abstract void Avanzar();
        public abstract void Detenerse();

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
