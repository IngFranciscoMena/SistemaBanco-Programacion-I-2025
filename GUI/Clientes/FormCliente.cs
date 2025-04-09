using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using EL;

namespace GUI.Clientes
{
    public partial class FormCliente : Form
    {
        private readonly ClienteBLL _clienteBLL;

        public FormCliente()
        {
            InitializeComponent();
            _clienteBLL = new ClienteBLL();

            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                bsClientes.DataSource = _clienteBLL.ObtenerClientes();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCliente();
        }

        private void GuardarCliente()
        {
            try
            {
                bsClientes.EndEdit();

                Cliente cliente = (Cliente)bsClientes.Current;

                cliente.IdEstado = 1;

                int resultado = _clienteBLL.GuardarCliente(cliente);

                if (resultado > 0)
                {
                    MessageBox.Show("El cliente ha sido registrado con exito!",
                        "Banco XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrio un error en el registro del cliente!",
                        "Banco XYZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                CargarClientes();
                panelForm.Enabled = false;
                panelConfig.Enabled = true;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            bsClientes.MoveLast();
            bsClientes.AddNew();
            panelForm.Enabled = true;
            panelConfig.Enabled = false;
        }
    }
}
