using BLL;
using EL;
using GUI.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
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

                var cuentas = cuentaBLL.ObtenerCuentas();

                // Expresiones Lambda
                bsCuentas.DataSource = cuentas
                    .Select(c => new CuentaDTO
                    {
                        IdCuentas = c.IdCuentas,
                        IdCliente = c.IdCliente,
                        Cliente = string.Concat(c.Cliente.Nombre, " ", c.Cliente.Apellido),
                        IdTipoCuenta = c.IdTipoCuenta,
                        TipoCuenta = c.TipoCuenta.Nombre,
                        Saldo = c.Saldo,
                        IdEstado = c.IdEstado,
                        Estado = c.Estado.Nombre
                    }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            bsCuentas.MoveLast();
            bsCuentas.AddNew();
            panelForm.Enabled = true;
            panelConfig.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCuenta();
        }

        private void GuardarCuenta()
        {
            try
            {
                cuentaBLL = new CuentaBLL();

                bsCuentas.EndEdit();

                CuentaDTO cuentaDTO = (CuentaDTO)bsCuentas.Current;

                Cuenta cuenta = new Cuenta()
                {
                    IdCliente = cuentaDTO.IdCliente,
                    IdTipoCuenta = cuentaDTO.IdTipoCuenta,
                    Saldo = cuentaDTO.Saldo,
                    IdEstado = cuentaDTO.IdEstado
                };

                int resultado = cuentaBLL.GuardarCuenta(cuenta);

                if (resultado > 0)
                {
                    MessageBox.Show("La cuenta ha sido registrada con exito!",
                        "Banco XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrio un error en el registro de la cuenta!",
                        "Banco XYZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                CargarCuentas();
                panelForm.Enabled = false;
                panelConfig.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrio un error: " + error.Message,
                        "Banco XYZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

// DTO
