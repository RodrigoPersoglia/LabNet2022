using LabNet2022.TP7.DataAccess.Commands;
using LabNet2022.TP7.Domain;
using LabNet2022.TP7.Domain.Entities;
using System.Collections.Generic;

namespace LabNet2022.TP7.Logic.Services
{
    public class ServiceCategories : IServiceCategories
    {
        private readonly ICategoriesRepository _repository;

        public ServiceCategories(ICategoriesRepository repository)
        {
            _repository = repository;
        }

        public void Agregar(Categories nuevo)
        {
            _repository.Agregar(nuevo);

        }

        public void Modificar(Categories modificado)
        {
            _repository.Modificar(modificado);

        }

        public void Eliminar(int id)
        {
            _repository.Eliminar(id);
        }

        public List<Categories> VerTodos()
        {
            return _repository.VerTodos();
        }

        public Categories BuscarPorID(int id)
        {
            return _repository.BuscarPorID(id);
        }
    }
}
