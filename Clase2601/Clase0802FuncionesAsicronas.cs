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
    public partial class Clase0802FuncionesAsicronas : Form
    {
        public Clase0802FuncionesAsicronas()
        {
            InitializeComponent();
        }

        private async void Hornearbutton_Click(object sender, EventArgs e)
        {

            //HornearPizza();
            await HornearPizzaAsync();
            label1.Text = "La pizza esta lista";
        }

        //cuando hay un async siempre habra un await

        private void HornearPizza()
        {
            Thread.Sleep(10000);
        }


        private Task HornearPizzaAsync()
        {
            return Task.Delay(10000);
        }

        private void Otrasbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Realizando otras tareas", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
        
        //*******************************************************************************
        private async void Sumarbutton_Click(object sender, EventArgs e)
        {
            decimal valor1 = Convert.ToDecimal(textBox1.Text);
            decimal valor2 = Convert.ToDecimal(textBox2.Text);
            MessageBox.Show("La suma es: " + await SumarAsync(valor1, valor2));
        }

        private decimal Sumar(decimal valor1, decimal valor2)
        {
            return valor1 + valor2;
        }

        private async Task <decimal> SumarAsync(decimal valor1, decimal valor2)
        {
            var resultado = await Task.Run(() =>
              {
                  return valor1 + valor2;
              });
           return resultado;
        }
    }
}
