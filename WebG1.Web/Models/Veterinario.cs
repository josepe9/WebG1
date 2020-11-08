using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebG1.Web.Models
{
    public class Veterinario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int PersonaId { get; set; }

        [StringLength(45)]
        public string Detalle { get; set; }

        public ICollection<Historia> Historias { get; set; }
    }
}
