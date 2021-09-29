using Microsoft.EntityFrameworkCore;
using GobernaRegistroBio.App.Dominio;

namespace GobernaRegistroBio.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> personas {get;set;}

        public DbSet<Personal_Aseo> personal_aseo {get;set;}

        public DbSet<Proveedores_Servicios> proveedores_servicios {get;set;}

        public DbSet<Registro> registros {get;set;}

        public DbSet<Secretarios_Despacho> secretarios_despacho {get;set;}

        public DbSet<Dependencia> dependencias {get;set;}

        //public DbSet<Genero> generos {get;set;} sin esta linea compila (creo que se debe al ser un enumerable)

        public DbSet<Gobernacion> gobernacion {get;set;}

        public DbSet<Gobernador_Asesores> gobernador_asesores {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog = GOBERNACION");
            }
        }




    }

}