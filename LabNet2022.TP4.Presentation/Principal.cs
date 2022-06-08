using LabNet2022.TP4.DataAccess.Commands;
using LabNet2022.TP4.Domain.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LabNet2022.TP4.Presentation
{
    public partial class Principal : Form
    {
        private readonly IServiceCategories _service;
        private readonly IServiceProducts _serviceProduct;
        private readonly ICategoriesRepository _repository;
        private readonly IProductsRepository _productsRepository;


        public Principal(IServiceCategories service, IServiceProducts serviceProduct, ICategoriesRepository repository, IProductsRepository productsRepository)
        {
            InitializeComponent();
            _service = service;
            _repository = repository;
            _serviceProduct = serviceProduct;
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Agregar = new AgregarCategoria(_service, _repository);
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
            var modificar = new ModificarCategoria(_service);
            modificar.MdiParent = this;
            modificar.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var eliminar = new EliminarCategoria(_service);
            eliminar.MdiParent = this;
            eliminar.Show();

        }

        private void verTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listado = new Listado(_service);
            listado.MdiParent = this;
            listado.Show();
        }

        private void verTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listado = new ListadoProductos(_serviceProduct, _productsRepository);
            listado.MdiParent = this;
            listado.Show();
        }
    }
}
