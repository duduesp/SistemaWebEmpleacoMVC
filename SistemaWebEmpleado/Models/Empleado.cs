using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using SistemaWebEmpleado.Validations;

namespace SistemaWebEmpleado.Models
{
    public class Empleado
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Campo Obligatorio")]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string Nombre { get; set; }


        [Required(ErrorMessage = "Campo Obligatorio")]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Required]
        public string DNI { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [RegularExpression("[A-Z]{2}[0-9]{5}")]
        public string Legajo { get; set; }

        [FechaNacimientoAttribute]
        public DateTime FechaNacimiento { get; set; }


        [Required(ErrorMessage = "Campo Obligatorio")]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string Titulo { get; set; }

    }
}
