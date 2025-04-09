using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTOs
{
    public class CuentaDTO
    {
        public int IdCuentas { get; set; }
        public int IdCliente { get; set; }
        public string Cliente { get; set; }
        public int IdTipoCuenta { get; set; }
        public string TipoCuenta { get; set; }
        public decimal Saldo { get; set; }
        public int IdEstado { get; set; }
        public string Estado { get; set; }
    }
}
