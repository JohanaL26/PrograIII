namespace Clase2601
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sumarbutton_Click(object sender, EventArgs e)
        {
            int num1 =  Convert.ToInt32(Num1textBox.Text);
            int num2 = Convert.ToInt32(Num2textBox.Text);
            ResultadotextBox.Text = Sumar(num1,num2).ToString();

        }




        private int Sumar(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;   
        }


        private void MostrarMensaje()
        {
            MessageBox.Show("Este es un mensaje");
        }

        private void Mostrarbutton_Click(object sender, EventArgs e)
        {
            MostrarMensaje();
        }
    }
}