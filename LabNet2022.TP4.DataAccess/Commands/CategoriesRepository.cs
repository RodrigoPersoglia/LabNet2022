using LabNet2022.TP4.Domain;
using LabNet2022.TP4.Domain.Entities;
using LabNet2022.TP4.Domain.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace LabNet2022.TP4.DataAccess.Commands
{
    public interface ICategoriesRepository
    {
        void Agregar(Categories nuevo);

        void Modificar(Categories modificado);

        void Eliminar(int id);

        List<Categories> VerTodos();

        Categories BuscarPorID(int id);

    }
    public class CategoriesRepository : ContextLogic, ICategoriesRepository
    {
        public void Agregar(Categories nuevo)
        {
            int id = _context.Categories.OrderByDescending(x => x.CategoryID).FirstOrDefault().CategoryID + 1;
            nuevo.CategoryID = id;
            _context.Categories.Add(nuevo);
            _context.SaveChanges();
        }

        public Categories BuscarPorID(int id)
        {
            return _context.Categories.Find(id);
        }

        public void Eliminar(int id)
        {
            var categoria = _context.Categories.Find(id);
            if (categoria == null) { throw new NoExisteException(); }
            if (_context.Products.Where(product => product.CategoryID == id).ToList().Count > 0)
            {
                throw new NoEliminaException("No se puede eliminar la categoría porque tiene productos asociados");
            }
            _context.Categories.Remove(categoria);
            _context.SaveChanges();
        }

        public void Modificar(Categories modificado)
        {
            var categoria = _context.Categories.Find(modificado.CategoryID);
            if (categoria == null) { throw new NoExisteException(); }
            categoria.CategoryName = modificado.CategoryName;
            categoria.Description = modificado.Description;
            categoria.Picture = modificado.Picture;
            _context.SaveChanges();

        }

        public List<Categories> VerTodos()
        {
            return _context.Categories.ToList();
        }
    }
}
