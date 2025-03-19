using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CargoDAL
    {
        private BancoDbContext _db;

        public CargoDAL(BancoDbContext db)
        {
            _db = db;
        }

        // Crear los metodos CRUD

        // Read -> Leer
        public List<Cargo> ObtenerCargos()
        {
            try
            {
                return _db.Cargos.ToList(); // Select * from Cargos
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
