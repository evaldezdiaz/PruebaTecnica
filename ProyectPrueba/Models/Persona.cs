using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebApiPrueba.Models
{
    public class Persona

    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public String Nombre { get; set; }

        [Display(Name = "Sexo")]
        public String Sexo { get; set; }

        [Range(1, 120,
            ErrorMessage = "La edad debe de ser mayor de 1 y menor que 120")]
        public int Edad { get; set; }
        
    }
    
    class PersonaDbContext : DbContext
    {
        public PersonaDbContext() : base("PersonaContext")
        {

        }
        public DbSet<Persona> Personas { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }

}