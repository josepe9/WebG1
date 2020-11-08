using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebG1.Web.Models
{
    public class Ciudad
    {
        public int Id { get; set; }

        [Required]
        [StringLength(45)]
        public string Nombre { get; set; }

        public ICollection<Persona> Personas { get; set; }

    }
}
