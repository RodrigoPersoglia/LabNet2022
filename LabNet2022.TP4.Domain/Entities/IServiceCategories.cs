using LabNet2022.TP7.Domain.EntitiesDTO;
using System.Collections.Generic;

namespace LabNet2022.TP7.Domain.Entities
{
    public interface IServiceCategories
    {
        void Agregar(CategoryDTO2 nuevo);

        void Modificar(int id, CategoryDTO2 modificado);

        void Eliminar(int id);

        List<CategoryDTO> VerTodos();
        CategoryDTO BuscarPorID(int id);

    }
}
