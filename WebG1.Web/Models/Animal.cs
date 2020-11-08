using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebG1.Web.Models
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(45)]
        public string Nombre { get; set; }

        [Required]
        public int RazaId { get; set; }

        [Required]
        public int EspecieId { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha nacimiento")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fechan { get; set; }

        [Required]
        public int PersonaId { get; set; }

        public ICollection<Historia> Historia { get; set; }

        public Raza Raza { get; set; }

        public Especie Especie { get; set; }

        public Persona Persona { get; set; }
    }
}
