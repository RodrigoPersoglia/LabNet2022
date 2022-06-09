using System.Collections.Generic;

namespace LabNet2022.TP4.Domain.Entities
{
    public interface IServiceSuppliers
    {
        void Agregar(Suppliers nuevo);

        void Modificar(Suppliers modificado);

        void Eliminar(int id);

        List<Suppliers> VerTodos();

    }
}
