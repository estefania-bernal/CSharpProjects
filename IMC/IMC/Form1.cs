namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoPeso = txtPeso.Text;
            double peso = Double.Parse(textoPeso); // peso en kg

            string textoAltura = txtAltura.Text;
            double altura = Double.Parse(textoAltura); //Altura en metros

            double imc = peso / (altura * altura);

            MessageBox.Show("El IMC es: " + imc);
        }
    }
}   