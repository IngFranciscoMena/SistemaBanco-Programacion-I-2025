using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BLL
{
    public class ClienteBLL
    {
        private readonly ClienteDAL _clienteDAL;
        private readonly CuentaBLL _cuentaBLL;
        private readonly BancoDbContext _db;
        
        public ClienteBLL()
        {
            this._db = new BancoDbContext();
            this._clienteDAL = new ClienteDAL(_db);
            this._cuentaBLL = new CuentaBLL();
        }

        // Mostrar clientes
        public List<Cliente> ObtenerClientes()
        {
            return _clienteDAL.ObtenerClientes();
        }

        // Crear cliente
        public int GuardarCliente(Cliente cliente, int id = 0, bool esActualizacion = false)
        {
            return _clienteDAL.Guardar(cliente, id, esActualizacion);
        }

        // Eliminar Cliente
        public int EliminarCliente(int id)
        {
            int resultado = 0;
            var cliente = _clienteDAL.ObtenerClientePorId(id);

            if (cliente != null)
            {
                var cuentas = _cuentaBLL.ObtenerCuentasActivasPorCliente(id);

                if (cuentas.Count == 0)
                {
                    resultado = _clienteDAL.EliminarCliente(cliente);
                }
            }

            return resultado;
        }


    }
}
