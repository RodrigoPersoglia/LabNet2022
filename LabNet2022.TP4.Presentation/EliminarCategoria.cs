using LabNet2022.TP4.Domain;
using LabNet2022.TP4.Logic.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LabNet2022.TP4.Presentation
{
    public partial class EliminarCategoria : Form
    {
        CrudCategories crud;
        public EliminarCategoria()
        {
            InitializeComponent();
            crud = new CrudCategories();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EliminarCategoria_Load(object sender, EventArgs e)
        {

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = decimal.ToInt32(ID.Value);
                crud.Eliminar(id);
            }

            catch (Exception) { MessageBox.Show("No se puedo eliminar la categoría", "LabNet2022", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

    }
}
