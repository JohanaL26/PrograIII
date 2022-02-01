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
    public partial class Clase3101 : Form
    {
        public Clase3101()
        {
            InitializeComponent();
        }

        private void Procesarbutton_Click(object sender, EventArgs e)
        {

            string cadena=CadenatextBox.Text;
            LongitudtextBox.Text = cadena.Length.ToString();
            PrimerCaractertextBox.Text = cadena.Substring(0,1);
            UltimoCaractertextBox.Text=cadena.Substring(cadena.Length-1,1);
            RangotextBox.Text = cadena.Substring(5, 10);
            MayustextBox.Text = cadena.ToUpper();
            MinustextBox.Text = cadena.ToLower();
            ReemplazartextBox.Text = cadena.Replace(" ", "");


        }
    }
}
