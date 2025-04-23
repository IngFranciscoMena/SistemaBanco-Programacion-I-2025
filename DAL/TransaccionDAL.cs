using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TransaccionDAL
    {
        private BancoDbContext _db;

        public TransaccionDAL(BancoDbContext db)
        {
            _db = db;
        }   

        // CRUD

        public List<Transaccion> ObtenerTransacciones()
        {
            try
            {
                return _db.Transacciones.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Guardar(Transaccion transaccion, int id = 0, bool esActualizacion = false)
        {
            try
            {
                int resultado = 0;

                if (esActualizacion)
                {
                    transaccion.IdTransacciones = id;

                    _db.Entry(transaccion).State = System.Data.Entity.EntityState.Modified;
                    _db.SaveChanges();

                    resultado = transaccion.IdTransacciones;
                }
                else
                {
                    _db.Transacciones.Add(transaccion);
                    _db.SaveChanges();

                    resultado = transaccion.IdTransacciones;
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
