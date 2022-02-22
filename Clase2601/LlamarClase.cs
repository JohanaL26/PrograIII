using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaClases;

namespace Clase2601
{
    public partial class LlamarClase : Form
    {
        public LlamarClase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Coche coche=new Coche(10, "Toyota");
            coche.Modelo = "22R";
            coche.Precio = 10000.00M;
            coche.Km = 150000;

            MessageBox.Show(coche.DevolverSatosCoche());




        }
    }
}
