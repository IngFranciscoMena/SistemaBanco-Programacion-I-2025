using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BLL
{
    public class EstadoBLL
    {
        private readonly EstadoDAL _estadoDAL;
        private readonly BancoDbContext _db;

        public EstadoBLL()
        {
            _db = new BancoDbContext();
            this._estadoDAL = new EstadoDAL(_db);
        }

        public List<Estado> ObtenerEstados()
        {
            return _estadoDAL.ObtenerEstados();
        }
    }
}
