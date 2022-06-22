using LabNet2022.TP7.Domain.EntitiesDTO;
using System.Collections.Generic;

namespace LabNet2022.TP7.Domain.Entities
{
    public interface IServiceCategories
    {
        void Agregar(CategoryDTO nuevo);

        void Modificar(CategoryDTO modificado);

        void Eliminar(int id);

        List<Categories> VerTodos();
        Categories BuscarPorID(int id);

    }
}
