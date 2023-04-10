namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double cateto1 = Double.Parse(txtCateto1.Text);
            double cateto2 = Double.Parse(txtCateto2.Text);

            double hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));

            MessageBox.Show("La Hipotenusa es:\n" + hipotenusa.ToString());
        }
    }
}