using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BLL
{
    public class TipoCuentaBLL
    {
        private readonly TipoCuentaDAL _tipoCuentaDAL;
        private readonly BancoDbContext _db;

        public TipoCuentaBLL()
        {
            _db = new BancoDbContext();
            this._tipoCuentaDAL = new TipoCuentaDAL(_db);
        }

        public List<TipoCuenta> ObtenerTipoCuentas()
        {
            return _tipoCuentaDAL.ObtenerTipoCuentas();
        }
    }
}
