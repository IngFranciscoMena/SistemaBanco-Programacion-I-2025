using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TransaccionBLL
    {
        private readonly TransaccionDAL _transaccionDAL;
        private readonly BancoDbContext _db;

        public TransaccionBLL()
        {
            this._db = new BancoDbContext();
            this._transaccionDAL = new TransaccionDAL(_db);
        }

        public int Guardar(Transaccion transaccion, int id = 0, bool esActualizacion = false)
        {
            return _transaccionDAL.Guardar(transaccion, id, esActualizacion);
        }

        // Logica de negocio
        public List<Transaccion> ObtenerTransaccionesDiaPorCliente(int idCliente)
        {
            var transacciones = _transaccionDAL.ObtenerTransacciones();

            // Fecha de ahora
            var fechaLimite = DateTime.Today;

            var transaccionesPorCliente = transacciones
                        .Where(t => t.Cuenta.IdCliente.Equals(idCliente) && t.Fecha >= fechaLimite)
                        .OrderByDescending(t => t.Fecha)
                        .ToList();

            return transaccionesPorCliente;
        }

        public List<Transaccion> ObtenerTransaccionesPorCliente(int idCliente)
        {
            var transacciones = _transaccionDAL.ObtenerTransacciones();

            var transaccionesPorCliente = transacciones.Where(t => t.Cuenta.IdCliente == idCliente).ToList();

            return transaccionesPorCliente;
        }

        public List<Transaccion> ObtenerTransaccionesPorDia()
        {
            var transacciones = _transaccionDAL.ObtenerTransacciones();

            // Fecha de ahora
            var fechaLimite = DateTime.Today;

            var transaccionesPorCliente = transacciones
                        .Where(t => t.Fecha >= fechaLimite)
                        .OrderByDescending(t => t.Fecha)
                        .ToList();

            return transaccionesPorCliente;
        }
    }
}
