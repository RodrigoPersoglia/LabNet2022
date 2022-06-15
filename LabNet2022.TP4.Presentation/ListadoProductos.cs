using LabNet2022.TP4.DataAccess.Commands;
using LabNet2022.TP4.Domain.Entities;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LabNet2022.TP4.Presentation
{
    public partial class ListadoProductos : Form
    {
        private readonly IServiceProducts _crud;
        private readonly IProductsRepository _repository;
        public ListadoProductos(IServiceProducts crud, IProductsRepository repository)
        {
            InitializeComponent();
            _crud = crud;
            _repository = repository;
        }

        private void ListadoProductos_Load(object sender, EventArgs e)
        {
            try
            {
                var ListadoProductos = _crud.VerTodos();
                foreach (var item in ListadoProductos)
                {
                    int n = Cuadro.Rows.Add();
                    Cuadro.Rows[n].Cells[0].Value = item.ProductID;
                    Cuadro.Rows[n].Cells[1].Value = item.ProductName;
                    Cuadro.Rows[n].Cells[2].Value = item.Suppliers.CompanyName;
                    Cuadro.Rows[n].Cells[3].Value = item.Categories.CategoryName;
                    Cuadro.Rows[n].Cells[4].Value = item.QuantityPerUnit;
                    Cuadro.Rows[n].Cells[5].Value = item.UnitPrice;
                    Cuadro.Rows[n].Cells[6].Value = item.UnitsInStock;
                    Cuadro.Rows[n].Cells[7].Value = item.UnitsOnOrder;
                    Cuadro.Rows[n].Cells[8].Value = item.ReorderLevel;
                    Cuadro.Rows[n].Cells[9].Value = item.Discontinued;
                }
            }
            catch (Exception) { }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Image byteArrayToImage(byte[] bytesArr)
        {
            try
            {
                using (MemoryStream memstr = new MemoryStream(bytesArr))
                {
                    Image img = Image.FromStream(memstr);
                    return img;
                }

            }
            catch (Exception) { return null; }

        }
    }
}
