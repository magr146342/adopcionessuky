using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web.adopsuky.Datos.Entidades
{
    public class Propietario
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Documento { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(100)]
        public string Direccion { get; set; }

        [Required]
        [MaxLength(20)]
        public string Celular { get; set; }

        [Required]
        [MaxLength(15)]
        public string Telefono { get; set; }

        [Display(Name = "Propietario")]
        public string NombreCompleto => $"{Nombre} {Apellido}";

        [Display(Name = "Propietario")]
        public string NombreConDoc => $"{Nombre} {Apellido} - {Documento}";
    }
}
