using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    [Table("Transacciones")]
    public class Transaccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTransacciones { get; set; }

        [ForeignKey("Cuenta")]
        public int IdCuenta { get; set; }
        public virtual Cuenta Cuenta { get; set; }

        [ForeignKey("TipoTransaccion")]
        public int IdTipoTransaccion { get; set; }
        public virtual TipoTransaccion TipoTransaccion { get; set; }

        [Required]
        [Column("monto_transaccion")]
        public decimal Monto { get; set; }

        [Required]
        [Column("fecha_transaccion")]
        public DateTime Fecha { get; set; }
    }
}
