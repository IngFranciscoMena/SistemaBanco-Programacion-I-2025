using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    [Table("Empleados")]
    public class Empleado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEmpleado { get; set; }

        [Required, StringLength(100)]
        [Column(name: "nombre_empleado")]
        public string Nombre { get; set; }

        [Required, StringLength(100)]
        [Column(name: "apellido_empleado")]
        public string Apellido { get; set; }

        [Required, StringLength(15)]
        [Column(name: "dni_empleado")]
        public string DNI { get; set; }

        [ForeignKey("Cargo")]
        public int IdCargo { get; set; }
        public virtual Cargo Cargo { get; set; }

        [ForeignKey("Departamento")]
        public int IdDepartamento { get; set; }
        public virtual Departamento Departamento { get; set; }

        [ForeignKey("Estado")]
        public int IdEstado { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
