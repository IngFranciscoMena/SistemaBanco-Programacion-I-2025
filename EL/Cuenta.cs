using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    [Table("Cuentas")]
    public class Cuenta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCuentas { get; set; }

        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }

        [ForeignKey("TipoCuenta")]
        public int IdTipoCuenta { get; set; }
        public virtual TipoCuenta TipoCuenta { get; set; }

        [Required]
        [Column(name: "saldo_cuenta")]
        public decimal Saldo { get; set; }

        [ForeignKey("Estado")]
        public int IdEstado { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
