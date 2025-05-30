﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BLL
{
    public class CuentaBLL
    {
        private readonly CuentaDAL _cuentaDAL;
        private readonly BancoDbContext _db;

        public CuentaBLL()
        {
            _db = new BancoDbContext();
            this._cuentaDAL = new CuentaDAL(_db);
        }

        public List<Cuenta> ObtenerCuentas()
        {
            return _cuentaDAL.ObtenerCuentas();
        }

        public int GuardarCuenta(Cuenta cuenta, int id = 0, bool esActualizacion = false)
        {
            return _cuentaDAL.Guardar(cuenta, id, esActualizacion);
        }

        public decimal ObtenerSaldoTotalPorCliente(int idCliente)
        {
            var cuentas = _cuentaDAL.ObtenerCuentas();

            decimal total = cuentas.Where(c => c.IdCliente.Equals(idCliente)).Sum(s => s.Saldo);

            return total;
        }

        public List<Cuenta> ObtenerCuentasActivasPorCliente(int idCliente)
        {
            var cuentas = _cuentaDAL.ObtenerCuentas();

            var cuentasActivas = cuentas.Where(c => c.IdCliente.Equals(idCliente) && c.Estado.Nombre.Equals("Activa")).ToList();

            return cuentasActivas;
        }

        public Cuenta ObtenerCuentaPorId(int id)
        {
            return _cuentaDAL.ObtenerCuentaPorId(id);
        }

        public decimal ObtenerSaldoTotalDeLasCuentas()
        {
            var cuentas = _cuentaDAL.ObtenerCuentas();

            decimal total = cuentas.Where(c => c.IdEstado == 1).Sum(s => s.Saldo);

            return total;
        }
    }
}
