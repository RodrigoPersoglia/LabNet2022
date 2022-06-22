using LabNet2022.TP7.DataAccess.Commands;
using LabNet2022.TP7.Domain;
using LabNet2022.TP7.Domain.Entities;
using LabNet2022.TP7.Domain.EntitiesDTO;
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

        public void Agregar(CategoryDTO nuevo)
        {
            var category = new Categories() { CategoryName = nuevo.CategoryName, Description = nuevo.Description };
            _repository.Agregar(category);

        }

        public void Modificar(CategoryDTO modificado)
        {
            var category = new Categories() { CategoryID = modificado.CategoryID, CategoryName = modificado.CategoryName, Description = modificado.Description };
            _repository.Modificar(category);

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
