using LabNet2022.TP4.Domain;
using LabNet2022.TP4.Logic.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LabNet2022.TP4.Presentation
{
    public partial class AgregarCategoria : Form
    {
        CrudCategories crud;
        public AgregarCategoria()
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

        private void AgregarCategoria_Load(object sender, EventArgs e)
        {

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var categoria = new Categories();
                if (NombreTXT.Text != "" && DescripcionTXT.Text != null)
                {
                    categoria.CategoryName = NombreTXT.Text;
                    categoria.Description = DescripcionTXT.Text;
                    try
                    {
                        categoria.Picture = ImageToByte(Imagen.Image);
                    }
                    catch (Exception) { categoria.Picture = null; }
                }
                crud.Agregar(categoria);
            }

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
            catch (Exception ){ MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido"); }
        }


        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

    }
}
