using POO.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Cliente cliente;
        Cuenta cuenta;
        MovimientoCuenta movimientoCuenta;
        List<MovimientoCuenta> ListaMovimientoCuenta;


        private void CrearCuentabutton_Click(object sender, EventArgs e)
        {
            //crear cliente
            cliente = new Cliente(IdentidadClientetextBox.Text, NombreClientetextBox.Text);
            //crear cuenta
            cuenta = new Cuenta(NumeroCuentatextBox.Text, cliente, DateTime.Now);
            SaldoCuentatextBox.Text = cuenta.Saldo.ToString("N");

        }

        private void AgregarMovimientobutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MontoMovimientotextBox.Text))
            {
                errorProvider1.SetError(MontoMovimientotextBox, "Ingrese un monto");
                MontoMovimientotextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(TipoMovimientocomboBox.Text))
            {
                errorProvider1.SetError(TipoMovimientocomboBox, "Seleccione el tipo de transacción");
                TipoMovimientocomboBox.Focus();
                return;
            }

            if (TipoMovimientocomboBox.Text=="Deposito")
            {
                //Deposito
                cuenta.Depositar(Convert.ToDecimal(MontoMovimientotextBox.Text));

                movimientoCuenta=new MovimientoCuenta(cuenta,DateTime.Now, Convert.ToDecimal(MontoMovimientotextBox.Text),
                                TipoMovimientocomboBox.Text);

                ListaMovimientoCuenta = new List<MovimientoCuenta>();
                ListaMovimientoCuenta.Add(movimientoCuenta);

                MovimientolistBox.Items.Add("Deposito a la cuenta N. " + cuenta.NumeroCuenta +" por la cantidad de L. " +
                    ""+movimientoCuenta.Monto+ " con fecha: "+movimientoCuenta.Fecha );

                SaldoCuentatextBox.Text = cuenta.Saldo.ToString("N");

            }
            else if (TipoMovimientocomboBox.Text=="Retiro")
            {
                //Retiro
                bool retiro = cuenta.Retirar(Convert.ToDecimal(MontoMovimientotextBox.Text));
                if (retiro)
                {
                    movimientoCuenta = new MovimientoCuenta(cuenta, DateTime.Now, Convert.ToDecimal(MontoMovimientotextBox.Text),
                                TipoMovimientocomboBox.Text);

                    ListaMovimientoCuenta = new List<MovimientoCuenta>();
                    ListaMovimientoCuenta.Add(movimientoCuenta);
                    MovimientolistBox.Items.Add("Retiro a la cuenta N. " + cuenta.NumeroCuenta + " por la cantidad de L. " +
                    "" + movimientoCuenta.Monto + " con fecha: " + movimientoCuenta.Fecha);
                    SaldoCuentatextBox.Text = cuenta.Saldo.ToString("N");



                }
                else
                {
                    MessageBox.Show("No tiene suficiente saldo para hacer el retiro");
                }

               
            }
            MontoMovimientotextBox.Clear();

        }
    }
}
