using LabNet2022.TP7.Domain;
using LabNet2022.TP7.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LabNet2022.TP7.DataAccess.Commands
{
    public interface ISuppliersRepository
    {
        bool Agregar(Suppliers nuevo);

        bool Modificar(Suppliers modificado);

        bool Eliminar(int id);

        List<Suppliers> VerTodos();

    }
    public class SuppliersRepository : ContextLogic, ISuppliersRepository
    {
        public bool Agregar(Suppliers nuevo)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(Suppliers modificado)
        {
            throw new NotImplementedException();
        }

        public List<Suppliers> VerTodos()
        {
            return _context.Suppliers.ToList();
        }

    }
}
