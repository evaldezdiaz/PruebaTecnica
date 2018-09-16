using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WebApiPrueba.Models;

namespace ProyectPrueba.ProyectDbContext
{
    public class PersonaDbContext : DbContext
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