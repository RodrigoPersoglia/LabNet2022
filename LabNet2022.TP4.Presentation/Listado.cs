using LabNet2022.TP4.Logic.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabNet2022.TP4.Presentation
{
    public partial class Listado : Form
    {
        CrudCategories crud;
        public Listado()
        {
            InitializeComponent();
            crud = new CrudCategories();
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            var listado = crud.VerTodos();
            foreach(var item in listado)
            {
                int n = Cuadro.Rows.Add();
                Cuadro.Rows[n].Cells[0].Value = item.CategoryID;
                Cuadro.Rows[n].Cells[1].Value = item.CategoryName;
                Cuadro.Rows[n].Cells[2].Value = item.Description;
                Cuadro.Rows[n].Cells[3].Value = item.Picture;
            }
        }
    }
}
