using LabNet2022.TP4.DataAccess.Commands;
using LabNet2022.TP4.Domain.Entities;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LabNet2022.TP4.Presentation
{
    public partial class ListadoProveedores : Form
    {
        private readonly IServiceSuppliers _service;
        private readonly ISuppliersRepository _repository;
        public ListadoProveedores(IServiceSuppliers service, ISuppliersRepository repository)
        {
            InitializeComponent();
            _service = service;
            _repository = repository;
        }

        private void ListadoProveedores_Load(object sender, EventArgs e)
        {
            try
            {
                var ListadoProveedores = _service.VerTodos();
                foreach (var item in ListadoProveedores)
                {
                    int n = Cuadro.Rows.Add();
                    Cuadro.Rows[n].Cells[0].Value = item.SupplierID;
                    Cuadro.Rows[n].Cells[1].Value = item.CompanyName;
                    Cuadro.Rows[n].Cells[2].Value = item.ContactName;
                    Cuadro.Rows[n].Cells[3].Value = item.ContactTitle;
                    Cuadro.Rows[n].Cells[4].Value = item.Address;
                    Cuadro.Rows[n].Cells[5].Value = item.City;
                    Cuadro.Rows[n].Cells[6].Value = item.Region;
                    Cuadro.Rows[n].Cells[7].Value = item.PostalCode;
                    Cuadro.Rows[n].Cells[8].Value = item.Country;
                    Cuadro.Rows[n].Cells[9].Value = item.Phone;
                    Cuadro.Rows[n].Cells[10].Value = item.Fax;
                    Cuadro.Rows[n].Cells[11].Value = item.HomePage;
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
