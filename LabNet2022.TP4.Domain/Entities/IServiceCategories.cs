using System.Collections.Generic;

namespace LabNet2022.TP4.Domain.Entities
{
    public interface IServiceCategories
    {
        void Agregar(Categories nuevo);

        void Modificar(Categories modificado);

        void Eliminar(int id);

        List<Categories> VerTodos();

    }
}
