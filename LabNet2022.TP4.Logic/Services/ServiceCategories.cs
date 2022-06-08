using LabNet2022.TP4.DataAccess.Commands;
using LabNet2022.TP4.Domain;
using LabNet2022.TP4.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LabNet2022.TP4.Logic.Services
{
    public class ServiceCategories : IServiceCategories
    {
        private readonly ICategoriesRepository _repository;

        public ServiceCategories(ICategoriesRepository repository)
        {
            _repository = repository;
        }

        public void Agregar(Categories nuevo)
        {
            try
            {
                if (_repository.Agregar(nuevo)) { MessageBox.Show("Registro Insertado Correctamente", "LabNet2022", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show("No se pudo insertar el registro", "LabNet2022", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "LabNet2022", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void Modificar(Categories modificado)
        {
            try
            {
                if (_repository.Modificar(modificado)) { MessageBox.Show("Registro Modificado Correctamente", "LabNet2022", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show("No se pudo modificar el registro", "LabNet2022", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "LabNet2022", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        public void Eliminar(int id)
        {
            try
            {
                if (_repository.Eliminar(id)) { MessageBox.Show("Registro Eliminado Correctamente", "LabNet2022", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show("No se pudo eliminar el registro", "LabNet2022", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "LabNet2022", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public List<Categories> VerTodos()
        {
            return _repository.VerTodos();
        }

    }
}
