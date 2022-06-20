using System.Collections.Generic;

namespace LabNet2022.TP7.Domain.Entities
{
    public interface IServiceProducts
    {
        void Agregar(Products nuevo);

        void Modificar(Products modificado);

        void Eliminar(int id);

        List<Products> VerTodos();

    }
}
