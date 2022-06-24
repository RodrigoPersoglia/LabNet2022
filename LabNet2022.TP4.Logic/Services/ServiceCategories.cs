using LabNet2022.TP7.DataAccess.Commands;
using LabNet2022.TP7.Domain;
using LabNet2022.TP7.Domain.Entities;
using LabNet2022.TP7.Domain.EntitiesDTO;
using LabNet2022.TP7.Domain.Exceptions;
using LabNet2022.TP8.Service.Mappers;
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

        public void Agregar(CategoryDTO2 nuevo)
        {
            if (nuevo == null) { throw new DatosException("Los datos recibidos son inválidos"); }
            var category = new Categories() { CategoryName = nuevo.CategoryName, Description = nuevo.Description };
            _repository.Agregar(category);
        }

        public void Modificar(int id, CategoryDTO2 modificado)
        {
            if (modificado == null) { throw new DatosException("Los datos recibidos son inválidos"); }
            var category = new Categories() { CategoryID = id, CategoryName = modificado.CategoryName, Description = modificado.Description };
            _repository.Modificar(category);
        }

        public void Eliminar(int id)
        {
            _repository.Eliminar(id);
        }

        public List<CategoryDTO> VerTodos()
        {

            var list = new List<CategoryDTO>();
            var mapper = new MapperCategories();
            foreach (var category in _repository.VerTodos())
            {
                list.Add(mapper.EntityToDto(category));
            }
            return list;
        }

        public CategoryDTO BuscarPorID(int id)
        {
            return new MapperCategories().EntityToDto(_repository.BuscarPorID(id));
        }
    }
}
