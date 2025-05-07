using BLL;
using GUI.Autenticacion;
using GUI.Clientes;
using GUI.Cuentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        private ClienteBLL _clientesBLL;
        private CuentaBLL _cuentaBLL;
        private TransaccionBLL _transaccionBLL;

        public Form1()
        {
            _clientesBLL = new ClienteBLL();
            _cuentaBLL = new CuentaBLL();
            _transaccionBLL = new TransaccionBLL();

            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            lblClientes.Text += $": {_clientesBLL.ObtenerClientes().Count}";
            lblTransacciones.Text += $": {_transaccionBLL.ObtenerTransaccionesPorDia().Count}";
            lblCuentas.Text += $": {_cuentaBLL.ObtenerCuentas().Count}";
            lblSaldos.Text += $": {_cuentaBLL.ObtenerSaldoTotalDeLasCuentas()}";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Login login = new Login();
            //login.Show();

            //this.Hide();
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente objCliente = new FormCliente();
            objCliente.ShowDialog();
        }

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCuenta objCuenta = new FormCuenta();
            objCuenta.ShowDialog();
        }
    }
}
