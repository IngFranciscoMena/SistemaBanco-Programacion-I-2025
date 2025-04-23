using DAL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuarioBLL
    {
        private readonly UsuarioDAL _usuarioDAL;
        private readonly BancoDbContext _db;

        public UsuarioBLL()
        {
            this._db = new BancoDbContext();
            this._usuarioDAL = new UsuarioDAL(_db);
        }

        public Usuario ObtenerUsuario(string correo, string contraseña)
        {
            return _usuarioDAL.ObtenerUsuario(correo, contraseña);
        }
    }
}
