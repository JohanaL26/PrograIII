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
    public partial class Clase0902Arreglos : Form
    {
        public Clase0902Arreglos()
        {
            InitializeComponent();
        }

        private void Ejecutarbutton_Click(object sender, EventArgs e)
        {
            //VECTORES
            int [] arreglo1=new int[5];
            arreglo1[0] = 40;
            arreglo1[1] = 10;
            arreglo1[2] = 30;
            arreglo1[3] = 60;
            arreglo1[4] = 80;

            int[] arreglo2 = new int[6] {41,63,45,68,74,99};  //otra forma de declarar un arreglo
            int[] arreglo3 = new int[] {2,5,1,3,7,6};  //otra forma de declarar un arreglo sin darleun tamaño
            int[] arreglo4 = {5,6,4,3,1,9,7}; //otra forma de declarar un arreglo

            string[] arreglo5 = { "Lunes","Martes","Miercoles","Jueves","Viernes","Sabado","Domingo" };

            //for comun
            //for (int i = 0; i < arreglo5.Length; i++)
            //{
            //    listBox1.Items.Add(arreglo5[i]);
            //}


            //foreach
            foreach (string item in arreglo5)
            {
                listBox1.Items.Add(item);
            }

        }



 //*******************************************************************************************************************
        //MATRICES
        private void Matrizbutton_Click(object sender, EventArgs e)
        {
            //matriz dada
            int[,] matriz1 = new int[2, 3]
            {{4,5,30 },{9,7,10} };

            //matriz para llenar
            int[,] matriz2 = new int[3, 3];
            for (int fila = 0; fila < matriz2.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz2.GetLength(1); columna++)
                {
                    matriz2[fila, columna] = 4 + (fila + 4) * (columna + 3);
                }
            }

            //mostrar matriz
            for (int fila = 0; fila < matriz2.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz2.GetLength(1); columna++)
                {
                    listBox2.Items.Add("la psoicion: [" + fila+","+columna+"] = "+matriz2[fila,columna]);
                }
            }

        }
    }
}
