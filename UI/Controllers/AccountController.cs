using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class AccountController : Controller
    {
        // Instancia de mi proyecto BLL
        private UsuarioBLL usuarioBLL;

        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string correo, string contraseña)
        {
            usuarioBLL = new UsuarioBLL();

            var usuario = usuarioBLL.ObtenerUsuario(correo, contraseña);

            if (usuario != null)
            {
                Session["ClienteId"] = usuario.IdCliente;
                Session["NombreCliente"] = $"{usuario.Cliente.Nombre} {usuario.Cliente.Apellido}";
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear(); // 🔹 Elimina todas las variables de sesión
            Session.Abandon(); // 🔹 Finaliza la sesión actual
            return RedirectToAction("Login", "Account"); // 🔹 Redirige al usuario al Login
        }
    }
}