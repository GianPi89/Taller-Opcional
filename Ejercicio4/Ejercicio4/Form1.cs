namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            num = int.Parse(txtNumeros.Text);
            if (num > 1 && num < 100) 
            { 
                MessageBox.Show(" El numero es: " + num);
            }
            else 
            {
                MessageBox.Show("Solo numeros entre 1 - 100", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

    }
}