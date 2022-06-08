using System.Collections.Generic;

namespace LabNet2022.TP4.Domain.Entities
{
    public interface ICrud<T>
    {
        void Agregar(T nuevo);

        void Modificar(T modificado);

        void Eliminar(int id);

        List<T> VerTodos();

    }
}
