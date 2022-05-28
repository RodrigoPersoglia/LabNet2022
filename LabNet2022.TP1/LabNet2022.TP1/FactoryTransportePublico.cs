namespace LabNet2022.TP1
{
    abstract class FactoryTransportePublico
    {
        const int OMNIBUS = 1;
        const int TAXI = 2;
        public static TransportePublico CrearTransporte(int opcion)
        {
            FactoryTransportePublico fabrica = null;

            switch (opcion)
            {
                case OMNIBUS:
                    fabrica = new FabricaOmnibus();
                    break;
                case TAXI:
                    fabrica = new FabricaTaxi();
                    break;
            }
            return fabrica.CrearTransporte();
        }

        public abstract TransportePublico CrearTransporte();
    }

    class FabricaOmnibus : FactoryTransportePublico
    {
        public override TransportePublico CrearTransporte()
        {
            var omnibus = new Omnibus(Funciones.ingresoNumero("ingrese la cantidad de pasajeros: "), Funciones.ingresoNumero("ingrese la capacidad del Omnibus: "));
            return omnibus;
        }
    }

    class FabricaTaxi : FactoryTransportePublico
    {
        public override TransportePublico CrearTransporte()
        {
            var omnibus = new Taxi(Funciones.ingresoNumero("ingrese la cantidad de pasajeros: "), Funciones.ingresoNumero("ingrese el valor de la bajada de bandera: "));
            return omnibus;
        }
    }

}
