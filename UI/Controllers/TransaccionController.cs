using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using EL;
using static UI.Models.Entidades;

namespace UI.Controllers
{
    public class TransaccionController : Controller
    {
        private TransaccionBLL _transaccionBLL;
        private CuentaBLL _cuentasBLL;

        // GET: Transaccion
        public ActionResult Index()
        {
            _transaccionBLL = new TransaccionBLL();
            _cuentasBLL = new CuentaBLL();

            int idCliente = int.Parse(Session["ClienteId"].ToString());

            var transacciones = _transaccionBLL.ObtenerTransaccionesPorCliente(idCliente);

            // Obtener Cuentas Activas
            var cuentasActivas = _cuentasBLL.ObtenerCuentasActivasPorCliente(idCliente);

            ViewBag.CuentasActivas = cuentasActivas;

            return View(transacciones);
        }

        [HttpPost]
        public ActionResult CrearTransaccion(int idOrigen, int idDestino, decimal monto)
        {
            _transaccionBLL = new TransaccionBLL();
            _cuentasBLL = new CuentaBLL();

            int idCliente = int.Parse(Session["ClienteId"].ToString());

            if (idOrigen <= 0 || idDestino <= 0)
            {
                return Json(new { success = false, message = "❌ Cuentas no validas" }, JsonRequestBehavior.AllowGet);
            }

            if (idDestino == idOrigen)
            {
                return Json(new { success = false, message = "❌ No se permite la transferencia a la misma cuenta" }, JsonRequestBehavior.AllowGet);
            }

            if (monto <= 0)
            {
                return Json(new { success = false, message = "❌ El monto a tranfereir debe ser mayor a 0" }, JsonRequestBehavior.AllowGet);
            }

            // Obtener las cuentas involucradas
            var cuentaOrigen = _cuentasBLL.ObtenerCuentaPorId(idOrigen);
            var cuentaDestino = _cuentasBLL.ObtenerCuentaPorId(idDestino);

            if (cuentaOrigen == null || cuentaDestino == null)
            {
                return Json(new { success = false, message = "❌ Cuentas no validas" }, JsonRequestBehavior.AllowGet);
            }

            if (monto >= cuentaOrigen.Saldo)
            {
                return Json(new { success = false, message = "❌ Fondos insuficientes" }, JsonRequestBehavior.AllowGet);
            }

            // Restar el monto de la cuenta de origen

            cuentaOrigen.Saldo -= monto;

            _cuentasBLL.GuardarCuenta(cuentaOrigen, idOrigen, true);

            // Sumar el monto a la cuenta de destino
            cuentaDestino.Saldo += monto;

            _cuentasBLL.GuardarCuenta(cuentaDestino, idDestino, true);

            // Crear la transaccion Origen (Debito)

            var transaccionOrigen = new Transaccion()
            {
                IdCuenta = idOrigen,
                IdTipoTransaccion = Convert.ToInt32(TipoTransacciones.Debito),
                Monto = monto,
                Fecha = DateTime.Now
            };

            _transaccionBLL.Guardar(transaccionOrigen);

            // Crear la transaccion Destino (Credito)

            var transaccionDestino = new Transaccion()
            {
                IdCuenta = idDestino,
                IdTipoTransaccion = Convert.ToInt32(TipoTransacciones.Credito),
                Monto = monto,
                Fecha = DateTime.Now
            };

            _transaccionBLL.Guardar(transaccionDestino);

            return Json(new { success = true, message = "Transacción realizada con éxito"}, JsonRequestBehavior.AllowGet);
        }
    }
}