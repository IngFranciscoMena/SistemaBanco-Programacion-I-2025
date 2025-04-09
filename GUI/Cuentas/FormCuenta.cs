using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Cuentas
{
    public partial class FormCuenta : Form
    {
        private CuentaBLL cuentaBLL;
        private ClienteBLL clienteBLL;
        private TipoCuentaBLL tipoCuentaBLL;
        private EstadoBLL estadoBLL;

        public FormCuenta()
        {
            InitializeComponent();

            CargarCuentas();
            CargarClientes();
            CargarTipoCuentas();
            CargarEstados();
        }

        private void CargarEstados()
        {
            try
            {
                estadoBLL = new EstadoBLL();

                bsEstados.DataSource = estadoBLL.ObtenerEstados();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CargarTipoCuentas()
        {
            try
            {
                tipoCuentaBLL = new TipoCuentaBLL();

                bsTipoCuentas.DataSource = tipoCuentaBLL.ObtenerTipoCuentas();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CargarClientes()
        {
            try
            {
                clienteBLL = new ClienteBLL();

                bsClientes.DataSource = clienteBLL.ObtenerClientes();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CargarCuentas()
        {
            try
            {
                cuentaBLL = new CuentaBLL();

                bsCuentas.DataSource = cuentaBLL.ObtenerCuentas();
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
