using LabNet2022.TP4.Domain;
using LabNet2022.TP4.Domain.Entities;
using LabNet2022.TP4.Domain.Exceptions;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LabNet2022.TP4.Presentation
{
    public partial class ModificarCategoria : Form
    {
        private readonly IServiceCategories _service;
        public ModificarCategoria(IServiceCategories service)
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

        private void ModificarCategoria_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            ID.Value = 0;
            NombreTXT.Text = "";
            DescripcionTXT.Text = "";
            Imagen.Image = null;
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var categoria = new Categories();
                if (NombreTXT.Text != "" && DescripcionTXT.Text != null)
                {
                    categoria.CategoryID = decimal.ToInt32(ID.Value);
                    categoria.CategoryName = NombreTXT.Text;
                    categoria.Description = DescripcionTXT.Text;
                    try
                    {
                        categoria.Picture = ImageToByte(Imagen.Image);
                    }
                    catch (Exception) { categoria.Picture = null; }
                    _service.Modificar(categoria);
                }
                else { MessageBox.Show("Hay Campos sin completar", "LabNet2022", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (NoExisteException ex) { MessageBox.Show(ex.Message, "LabNet2022", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "LabNet2022", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                var openFileDialog1 = new OpenFileDialog();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    Imagen.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception) { MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido"); }
        }


        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
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
    }
}
