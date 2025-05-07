using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private CuentaBLL _cuentasBLL;
        private TransaccionBLL _transaccionesBLL;

        public ActionResult Index()
        {
            _cuentasBLL = new CuentaBLL();
            _transaccionesBLL = new TransaccionBLL();

            int idCliente = int.Parse(Session["ClienteId"].ToString());

            // Obtener Saldo Total de las Cuentas
            decimal saldo = _cuentasBLL.ObtenerSaldoTotalPorCliente(idCliente);

            // Obtener Cuentas Activas
            var cuentasActivas = _cuentasBLL.ObtenerCuentasActivasPorCliente(idCliente);

            // Obtener Transacciones del dia
            var transacciones = _transaccionesBLL.ObtenerTransaccionesDiaPorCliente(idCliente);

            // Pasar los datos a la vista
            ViewBag.Saldo = saldo;
            ViewBag.CuentasActivas = cuentasActivas;
            ViewBag.Transacciones = transacciones;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}