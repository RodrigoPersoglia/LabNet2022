using LabNet2022.TP4.Domain;
using LabNet2022.TP4.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LabNet2022.TP4.Logic.Services
{
    public class CrudCategories : ContextLogic, ICrud<Categories>
    {
        public void Agregar(Categories nuevo)
        {
            try
            {
                int id = _context.Categories.OrderByDescending(x => x.CategoryID).FirstOrDefault().CategoryID + 1;
                nuevo.CategoryID = id;
                _context.Categories.Add(nuevo);
                _context.SaveChanges();
                MessageBox.Show("Registro Insertado Correctamente", "LabNet2022", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "LabNet2022", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void Modificar(Categories modificado)
        {
            try
            {
                var categoria = _context.Categories.Find(modificado.CategoryID);
                if (categoria != null)
                {
                    categoria.CategoryName = modificado.CategoryName;
                    categoria.Description = modificado.Description;
                    categoria.Picture = modificado.Picture;
                    _context.SaveChanges();
                    MessageBox.Show("Registro Modificado Correctamente", "LabNet2022", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else { MessageBox.Show("La categoría que intenta modificar no existe", "LabNet2022", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "LabNet2022", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        public void Eliminar(int id)
        {
            try
            {
                var categoria = _context.Categories.Find(id);
                if (categoria != null)
                {
                    _context.Categories.Remove(categoria);
                    _context.SaveChanges();
                    MessageBox.Show("Registro Eliminado Correctamente", "LabNet2022", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { MessageBox.Show("La categoría que eliminar modificar no existe", "LabNet2022", MessageBoxButtons.OK, MessageBoxIcon.Error); }


            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "LabNet2022", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public List<Categories> VerTodos()
        {
            return _context.Categories.ToList();
        }

    }
}
