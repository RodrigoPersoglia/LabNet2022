using LabNet2022.TP4.Domain.Entities;
using LabNet2022.TP7.Domain.Entities;
using Newtonsoft.Json;
using System.IO;
using System.Net;


namespace LabNet2022.TP7.DataAccess.Commands
{
    public interface IProvinciasRepository
    {
        Pais GetProvincias();

    }
    public class ProvinciasRepository : ContextLogic, IProvinciasRepository
    {

        public Pais GetProvincias()
        {
            string respuesta = getHttp();
            Pais pais = JsonConvert.DeserializeObject<Pais>(respuesta);
            return pais;
        }

        public static string getHttp()
        {
            WebRequest oRequest = WebRequest.Create("https://apis.datos.gob.ar/georef/api/provincias");
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return sr.ReadToEnd().Trim();
        }

    }





}
