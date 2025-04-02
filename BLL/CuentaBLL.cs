using System;
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
    }
}
