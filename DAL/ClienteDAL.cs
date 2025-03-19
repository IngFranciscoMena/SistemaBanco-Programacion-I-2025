using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClienteDAL
    {
        // 1- Crear una instancia del DbContext
        private BancoDbContext _db;

        // 2- Inyectar el DbContext a nuestra clase DAL
        public ClienteDAL(BancoDbContext db)
        {
            // 3- Inicializar nuestro DbContext
            _db = db;
        }

        // Comenzamos a desarrollar nuestro CRUD

        // Create & Update
        public int Guardar(Cliente cliente, int id = 0, bool esActualizacion = false)
        {
            try
            {
                int resultado = 0;

                if (esActualizacion)
                {
                    cliente.IdCliente = id;

                    _db.Entry(cliente).State = System.Data.Entity.EntityState.Modified; // update clientes set ... where idCliente = id
                    _db.SaveChanges();

                    resultado = cliente.IdCliente;
                } 
                else
                {
                    _db.Clientes.Add(cliente); // Insert Into Cliente() values();
                    _db.SaveChanges();

                    resultado = cliente.IdCliente;
                }

                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Read
        public List<Cliente> ObtenerClientes()
        {
            try
            {
                // Devolver el listado de Cliente
                return _db.Clientes.ToList(); // select * from Clientes
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Delete
    }
}
