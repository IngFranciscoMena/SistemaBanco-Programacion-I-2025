using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }

        [Required, StringLength(100)]
        [Column(name: "correo_usuario")]
        public string Correo { get; set; }

        [Required, StringLength(255)]
        [Column(name: "contraseña_usuario")]
        public string Contraseña { get; set; }

        [ForeignKey("Rol")]
        public int IdRol { get; set; }
        public virtual Rol Rol { get; set; }  // Relación con Roles

        [ForeignKey("Cliente")]
        public int? IdCliente { get; set; } = null;
        public virtual Cliente Cliente { get; set; }  // Relación con Cliente

        [ForeignKey("Empleado")]
        public int? IdEmpleado { get; set; } = null;
        public virtual Empleado Empleado { get; set; }  // Relación con Empleado
    }
}
