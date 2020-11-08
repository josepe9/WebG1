using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebG1.Web.Models
{
    public class Enfermedad
    {
        public int Id { get; set; }

        [Required]
        [StringLength(45)]
        public string Nombre { get; set; }

        [StringLength(45)]
        public string Detalle { get; set; }

        public ICollection<Historia> Historia { get; set; }
    }
}
