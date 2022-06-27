using LabNet2022.TP7.Domain;
using LabNet2022.TP7.Domain.Entities;
using LabNet2022.TP7.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LabNet2022.TP7.DataAccess.Commands
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
            try
            {
                if (nuevo == null) { throw new DatosException("Los datos recibidos son inválidos"); }
                int id = _context.Categories.OrderByDescending(x => x.CategoryID).FirstOrDefault().CategoryID + 1;
                nuevo.CategoryID = id;
                _context.Categories.Add(nuevo);
                _context.SaveChanges();
            }
            catch (DatosException) { throw new DatosException("Los datos recibidos son inválidos"); }
            catch (Exception) { throw new Exception(); }

        }

        public Categories BuscarPorID(int id)
        {
            try
            {
                var category = _context.Categories.Find(id);
                if (category == null) { throw new NoExisteException($"el registro nº {id} no existe en la base de datos"); }
                return category;
            }
            catch (NoExisteException) { throw new NoExisteException($"el registro nº {id} no existe en la base de datos"); }
            catch (Exception) { throw new Exception(); }

        }

        public void Eliminar(int id)
        {
            try
            {
                var categoria = _context.Categories.Find(id);
                if (categoria == null) { throw new NoExisteException($"el registro nº {id} no existe en la base de datos"); }
                if (_context.Products.Where(product => product.CategoryID == id).ToList().Count > 0)
                {
                    throw new NoEliminaException($"No se puede eliminar la categoría con el id nº {id} porque tiene productos asociados");
                }
                _context.Categories.Remove(categoria);
                _context.SaveChanges();
            }
            catch (NoExisteException) { throw new NoExisteException($"el registro nº {id} no existe en la base de datos"); }
            catch (NoEliminaException) { throw new NoEliminaException($"No se puede eliminar la categoría con el id nº {id} porque tiene productos asociados"); }
            catch (Exception) { throw new Exception(); }

        }

        public void Modificar(Categories modificado)
        {
            try
            {
                if (modificado == null) { throw new DatosException("Los datos recibidos son inválidos"); }
                var categoria = _context.Categories.Find(modificado.CategoryID);
                if (categoria == null) { throw new NoExisteException($"el registro nº {modificado.CategoryID} no existe en la base de datos"); }
                categoria.CategoryName = modificado.CategoryName;
                categoria.Description = modificado.Description;
                categoria.Picture = modificado.Picture;
                _context.SaveChanges();
            }
            catch (DatosException) { throw new DatosException("Los datos recibidos son inválidos"); }
            catch (NoExisteException) { throw new NoExisteException($"el registro nº {modificado.CategoryID} no existe en la base de datos"); }
            catch (Exception) { throw new Exception(); }
        }


        public List<Categories> VerTodos()
        {
            return _context.Categories.ToList();
        }


    }
}
