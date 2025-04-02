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
        private readonly BancoDbContext _db;
        
        public ClienteBLL()
        {
            this._db = new BancoDbContext();
            _clienteDAL = new ClienteDAL(_db);
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

    }
}
