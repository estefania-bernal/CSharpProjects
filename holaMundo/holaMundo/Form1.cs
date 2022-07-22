namespace holaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //string prueba2 = "Prueba" + "de" + "concatenacion. " + prueba;
            //en esta parte cree una variable para obtener la edad
            string textoEdad = txtEdad.Text;
            //convertimos el texto a numero
            int edad = Int32.Parse(textoEdad);
            bool esMayorDeEdad = edad >= 18;

            
            
            if (esMayorDeEdad)
            {
                lblResultado.Text = "El usuario es mayor de edad";
            }
            else
            {
                lblResultado.Text = "El usuario es menor de edad";
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    } 
}