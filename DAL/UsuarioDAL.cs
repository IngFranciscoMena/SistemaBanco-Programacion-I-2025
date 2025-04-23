using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDAL
    {
        private BancoDbContext _db;

        public UsuarioDAL(BancoDbContext db)
        {
            _db = db;
        }

        public Usuario ObtenerUsuario(string correo, string contraseña)
        {
            try
            {
                // Select * from Usuarios Where usuario = @user and contraseña = @pwd
                Usuario user = _db.Usuarios.Where(u => u.Correo.Equals(correo) && u.Contraseña.Equals(contraseña)).FirstOrDefault();

                return user;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
