using System;
using System.Windows.Forms;

namespace LabNet2022.TP2
{
    public partial class LabNet2022 : Form
    {
        public LabNet2022()
        {
            InitializeComponent();
        }

        private double DivisionAleatoria(int divisor)
        {
            int dividendo = new Random().Next(1, 1000);
            return dividendo.dividir(divisor);
        }

        public double Division(int divisor, int dividendo)
        {
            return divisor.dividir(dividendo);
        }

        private void DividirBotton_Click(object sender, EventArgs e)
        {
            Result1.Text = "";
            try
            {
                Result1.Text = DivisionAleatoria(decimal.ToInt32(Dividendo1.Value)).ToString();
            }
            catch (DivideByZeroException ex) { MessageBox.Show(ex.Message, ".NET Lab 2022", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show(ex.Message, ".NET Lab 2022", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { MessageBox.Show("La operación Finalizo", ".NET Lab 2022", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void DividirBotton2_Click(object sender, EventArgs e)
        {
            Result2.Text = "";
            try
            {
                Result2.Text = Math.Round(Division(decimal.ToInt32(Divisor2.Value), int.Parse(Dividendo2.Text)), 4).ToString();
            }
            catch (DivideByZeroException ex) { MessageBox.Show($"Solo Chuck Norris divide por cero! Error: {ex.Message}", ".NET Lab 2022", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (FormatException) { MessageBox.Show("Seguro Ingreso una letra o no ingreso nada!", ".NET Lab 2022", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show(ex.Message, ".NET Lab 2022", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { MessageBox.Show("La operación Finalizo", ".NET Lab 2022", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void LanzarBotton3_Click(object sender, EventArgs e)
        {
            try
            {
                Logic.LanzarException();
            }
            catch (Exception ex) { MessageBox.Show($"Tipo Exception: {ex.GetType().Name}, Message: {ex.Message}", ".NET Lab 2022", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void LanzarBotton4_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    Logic.LanzarCustomException();
                }
                catch (Exception ex) { MessageBox.Show($"Tipo Exception: {ex.GetType().Name}, Message: {ex.Message}", ".NET Lab 2022", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }
    }
}
