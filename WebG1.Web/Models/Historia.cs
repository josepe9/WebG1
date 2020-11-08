using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebG1.Web.Models
{
    public class Historia
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        [Required]
        public int AnimalId { get; set; }

        [Required]
        public int EnfermedadId { get; set; }

        [StringLength(45)]
        public string Detalle { get; set; }

        [Required]
        public int VeterinarioId { get; set; }

        public Animal Animal { get; set; }

        public Enfermedad Enfermedad { get; set; }

        public Veterinario Veterinario { get; set; }
    }
}
