using LabNet2022.TP4.Domain.Entities;
using System;
using System.Windows.Forms;

namespace LabNet2022.TP4.Presentation
{
    public partial class Listado : Form
    {
        private readonly IServiceCategories _crud;
        public Listado(IServiceCategories crud)
        {
            InitializeComponent();
            _crud = crud;
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            var listado = _crud.VerTodos();
            foreach (var item in listado)
            {
                int n = Cuadro.Rows.Add();
                Cuadro.Rows[n].Cells[0].Value = item.CategoryID;
                Cuadro.Rows[n].Cells[1].Value = item.CategoryName;
                Cuadro.Rows[n].Cells[2].Value = item.Description;
                Cuadro.Rows[n].Cells[3].Value = item.Picture;
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
