﻿using GUI.Autenticacion;
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
        public Form1()
        {
            InitializeComponent();
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
