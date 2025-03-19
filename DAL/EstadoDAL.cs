using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EstadoDAL
    {
        private BancoDbContext _db;

        public EstadoDAL(BancoDbContext db)
        {
            _db = db;
        }

        // Read
        public List<Estado> ObtenerEstados()
        {
            try
            {
                return _db.Estados.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
