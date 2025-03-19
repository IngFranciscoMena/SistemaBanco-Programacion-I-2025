using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCliente { get; set; }

        [Required, StringLength(100)]
        [Column(name: "nombre_cliente")]
        public string Nombre { get; set; }

        [Required, StringLength(100)]
        [Column(name: "apellido_cliente")]
        public string Apellido { get; set; }

        [Required, StringLength(15)]
        [Column(name: "dni_cliente")]
        public string DNI { get; set; }

        [StringLength(20)]
        [Column(name: "telefono_cliente")]
        public string Telefono { get; set; }

        // Se agrega llave foranea
        [ForeignKey("Estado")]
        public int IdEstado { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
