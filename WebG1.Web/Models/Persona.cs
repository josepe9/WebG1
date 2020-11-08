using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebG1.Web.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        public string Documento { get; set; }

        [Required]
        [StringLength(45)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(45)]
        public string Direccion { get; set; }

        [Required]
        public int CiudadId { get; set; }

        [StringLength(45)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }

        public ICollection<Animal> Animales { get; set; }

        public Ciudad Ciudad { get; set; }
    }
}
