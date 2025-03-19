using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    [Table("TipoCuentas")]
    public class TipoCuenta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoCuenta { get; set; }

        [Required, StringLength(50)]
        [Column(name: "nombre_tipo_cuenta")]
        public string Nombre { get; set; }  // Puede ser "Ahorro", "Corriente"
    }
}
