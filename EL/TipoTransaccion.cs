using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    [Table("TipoTransacciones")]
    public class TipoTransaccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoTransaccion { get; set; }

        [Required, StringLength(50)]
        [Column(name: "nombre_tipo_transaccion")]
        public string Nombre { get; set; }  // Puede ser "Depósito", "Retiro", "Transferencia"
    }
}
