using LabNet2022.TP7.Domain;
using LabNet2022.TP7.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LabNet2022.TP7.DataAccess.Commands
{
    public interface IProductsRepository
    {
        bool Agregar(Products nuevo);

        bool Modificar(Products modificado);

        bool Eliminar(int id);

        List<Products> VerTodos();

    }
    public class ProductsRepository : ContextLogic, IProductsRepository
    {
        public bool Agregar(Products nuevo)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(Products modificado)
        {
            throw new NotImplementedException();
        }

        public List<Products> VerTodos()
        {
            return _context.Products.Include("Categories").Include("Suppliers").ToList();
        }

    }
}
