using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;

namespace DAL
{
    public class CuentaDAL
    {
        private readonly BancoDbContext _db;

        public CuentaDAL(BancoDbContext db)
        {
            _db = db;
        }

        public List<Cuenta> ObtenerCuentas()
        {
            try
            {
                return _db.Cuentas.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Cuenta ObtenerCuentaPorId(int id)
        {
            try
            {
                return _db.Cuentas.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Guardar(Cuenta cuenta, int id = 0, bool esActualizacion = false)
        {
            try
            {
                int resultado = 0;

                if (esActualizacion)
                {
                    cuenta.IdCuentas = id;

                    _db.Entry(cuenta).State = System.Data.Entity.EntityState.Modified;
                    _db.SaveChanges();

                    resultado = cuenta.IdCuentas;
                }
                else
                {
                    _db.Cuentas.Add(cuenta);
                    _db.SaveChanges();

                    resultado = cuenta.IdCuentas;
                }

                return resultado;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
