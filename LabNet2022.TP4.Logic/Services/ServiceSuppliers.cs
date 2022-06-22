using LabNet2022.TP7.DataAccess.Commands;
using LabNet2022.TP7.Domain;
using LabNet2022.TP7.Domain.Entities;
using System;
using System.Collections.Generic;

namespace LabNet2022.TP7.Logic.Services
{
    public class ServiceSuppliers : IServiceSuppliers
    {
        private readonly ISuppliersRepository _repository;

        public ServiceSuppliers(ISuppliersRepository repository)
        {
            _repository = repository;
        }

        public void Agregar(Suppliers nuevo)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Suppliers modificado)
        {
            throw new NotImplementedException();
        }

        public List<Suppliers> VerTodos()
        {
            return _repository.VerTodos();
        }

    }
}
