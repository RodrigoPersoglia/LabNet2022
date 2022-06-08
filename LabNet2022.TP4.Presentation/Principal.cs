using System;
using System.Drawing;
using System.Windows.Forms;

namespace LabNet2022.TP4.Presentation
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Agregar = new AgregarCategoria();
            Agregar.MdiParent = this;
            Agregar.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            MdiClient oMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    oMDI = (MdiClient)ctl;
                    oMDI.BackColor = Color.Navy;
                }
                catch (InvalidCastException)
                {
                }
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var modificar = new ModificarCategoria();
            modificar.MdiParent = this;
            modificar.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var eliminar = new EliminarCategoria();
            eliminar.MdiParent = this;
            eliminar.Show();

        }

        private void verTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listado = new Listado();
            listado.MdiParent = this;
            listado.Show();

        }
    }
}
