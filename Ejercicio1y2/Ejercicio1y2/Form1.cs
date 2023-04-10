namespace Ejercicio1y2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num;
            num = int.Parse(txtNumero.Text);

            if (num % 2 == 0)
            {
                MessageBox.Show(" El numero es par ");
            }
            else
            {
                MessageBox.Show(" El numero es impar");
            }
            if (num == 0)
            {
                MessageBox.Show(" El numero es cero");
            }
            else if (num > 0)
            {
                MessageBox.Show(" El numero es positivo");
            }
            else
            {
                MessageBox.Show(" El numero es negativo");
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 42) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}