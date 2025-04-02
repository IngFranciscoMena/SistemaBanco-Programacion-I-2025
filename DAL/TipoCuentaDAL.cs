using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;

namespace DAL
{
    public class TipoCuentaDAL
    {
        private readonly BancoDbContext _db;

        public TipoCuentaDAL(BancoDbContext db)
        {
            _db = db;
        }

        public List<TipoCuenta> ObtenerTipoCuentas()
        {
            try
            {
                return _db.TipoCuentas.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
