using LabNet2022.TP4.Domain.Entities;
using LabNet2022.TP4.Domain.Exceptions;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LabNet2022.TP4.Presentation
{
    public partial class EliminarCategoria : Form
    {
        private readonly IServiceCategories _service;
        public EliminarCategoria(IServiceCategories service)
        {
            InitializeComponent();
            _service = service;
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
                _service.Eliminar(id);
            }
            catch (NoEliminaException ex) { MessageBox.Show(ex.Message, "LabNet2022", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (NoExisteException ex) { MessageBox.Show(ex.Message, "LabNet2022", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "LabNet2022", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ID_ValueChanged(object sender, EventArgs e)
        {
            var categoria = _service.BuscarPorID(decimal.ToInt32(ID.Value));
            if (categoria != null)
            {
                NombreTXT.Text = categoria.CategoryName;
                DescripcionTXT.Text = categoria.Description;
                Imagen.Image = byteArrayToImage(categoria.Picture);
            }
            else { Limpiar(); }
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

        private void Limpiar()
        {
            ID.Value = 0;
            NombreTXT.Text = "";
            DescripcionTXT.Text = "";
            Imagen.Image = null;
        }
    }
}
