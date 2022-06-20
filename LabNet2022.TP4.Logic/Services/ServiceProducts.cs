using LabNet2022.TP7.DataAccess.Commands;
using LabNet2022.TP7.Domain;
using LabNet2022.TP7.Domain.Entities;
using System;
using System.Collections.Generic;

namespace LabNet2022.TP7.Logic.Services
{
    public class ServiceProducts : IServiceProducts
    {
        private readonly IProductsRepository _repository;

        public ServiceProducts(IProductsRepository repository)
        {
            _repository = repository;
        }

        public void Agregar(Products nuevo)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Products modificado)
        {
            throw new NotImplementedException();
        }

        public List<Products> VerTodos()
        {
            return _repository.VerTodos();
        }

    }
}
