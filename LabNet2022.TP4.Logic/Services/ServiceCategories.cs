using LabNet2022.TP4.DataAccess.Commands;
using LabNet2022.TP4.Domain;
using LabNet2022.TP4.Domain.Entities;
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
            _repository.Agregar(nuevo);
            MessageBox.Show("Registro Insertado Correctamente", "LabNet2022", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Modificar(Categories modificado)
        {
            _repository.Modificar(modificado);
            MessageBox.Show("Registro Modificado Correctamente", "LabNet2022", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Eliminar(int id)
        {
            _repository.Eliminar(id);
            MessageBox.Show("Registro Eliminado Correctamente", "LabNet2022", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public List<Categories> VerTodos()
        {
            return _repository.VerTodos();
        }

        public Categories BuscarPorID(int id)
        {
            return _repository.BuscarPorID(id);
        }
    }
}
