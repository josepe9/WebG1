using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebG1.Web.Models;

namespace WebG1.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Animal> Animales { get; set; }
        public virtual DbSet<Raza> Razas { get; set; }
        public virtual DbSet<Especie> Especies { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Ciudad> Ciudades { get; set; }
        public virtual DbSet<Enfermedad> Enfermedades { get; set; }
        public virtual DbSet<Historia> Historias { get; set; }
        public virtual DbSet<Veterinario> Veterinario { get; set; }
    }
}
