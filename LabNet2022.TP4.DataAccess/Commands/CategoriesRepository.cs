using LabNet2022.TP4.Domain;
using LabNet2022.TP4.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LabNet2022.TP4.DataAccess.Commands
{
    public interface ICategoriesRepository
    {
        bool Agregar(Categories nuevo);

        bool Modificar(Categories modificado);

        bool Eliminar(int id);

        List<Categories> VerTodos();

    }
    public class CategoriesRepository : ContextLogic, ICategoriesRepository
    {
        public bool Agregar(Categories nuevo)
        {
            try
            {
                int id = _context.Categories.OrderByDescending(x => x.CategoryID).FirstOrDefault().CategoryID + 1;
                nuevo.CategoryID = id;
                _context.Categories.Add(nuevo);
                _context.SaveChanges();
                return true;
            }
            catch (Exception) { return false; }

        }

        public bool Eliminar(int id)
        {

            var categoria = _context.Categories.Find(id);
            if (categoria != null)
            {
                _context.Categories.Remove(categoria);
                _context.SaveChanges();
                return true;
            }
            return false;

        }

        public bool Modificar(Categories modificado)
        {
            var categoria = _context.Categories.Find(modificado.CategoryID);
            if (categoria != null)
            {
                categoria.CategoryName = modificado.CategoryName;
                categoria.Description = modificado.Description;
                categoria.Picture = modificado.Picture;
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Categories> VerTodos()
        {
            return _context.Categories.ToList();
        }
    }
}
