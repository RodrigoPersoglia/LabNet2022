using LabNet2022.TP4.Domain.Entities;
//using LabNet2022.TP4.Domain.EntitiesDTO;
using LabNet2022.TP7.DataAccess.Commands;

namespace LabNet2022.TP7.Logic.Services
{
    public interface IServiceProvincias
    {
        Pais GetProvincias();
    }


    public class ServiceProvincias : IServiceProvincias
    {
        private readonly IProvinciasRepository _repository;
        public ServiceProvincias()
        {
            _repository = new ProvinciasRepository();
        }

        public Pais GetProvincias()
        {
            return _repository.GetProvincias();
        }


    }
}
