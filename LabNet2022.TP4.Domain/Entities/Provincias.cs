using System.Collections.Generic;

namespace LabNet2022.TP4.Domain.Entities
{
    public class Pais
    {
        public int cantidad { get; set; }
        public int inicio { get; set; }
        public Parametros parametros { get; set; }
        public IList<Provincia> provincias { get; set; }
        public int total { get; set; }
    }

    public class Parametros
    {
    }

    public class Centroide
    {
        public double lat { get; set; }
        public double lon { get; set; }
    }

    public class Provincia
    {
        public Centroide centroide { get; set; }
        public string id { get; set; }
        public string nombre { get; set; }
    }
}
