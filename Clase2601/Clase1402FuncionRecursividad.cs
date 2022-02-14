using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase2601
{
    public partial class Clase1402FuncionRecursividad : Form
    {
        public Clase1402FuncionRecursividad()
        {
            InitializeComponent();
        }

        private void Ejecutarbutton_Click(object sender, EventArgs e)
        {
            //RecorrerDeUnoEnUno(10, 30);
            RecorrerDeUnoEnUno(Convert.ToInt32(textBox1.Text), Convert.ToInt32( textBox2.Text));
        }


        private void RecorrerDeUnoEnUno( int ValorInicial, int ValorFinal)
        {
            listBox1.Items.Add(ValorInicial);
  
            if (ValorInicial < ValorFinal) 
            {
                RecorrerDeUnoEnUno(ValorInicial +1, ValorFinal);
            }
        }

    }
}
