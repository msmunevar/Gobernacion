using Microsoft.EntityFrameworkCore;
using GobernaRegistroBio.App.Dominio;

namespace GobernaRegistroBio.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}

        public DbSet<Dependencia> Dependencias {get;set;}

        public DbSet<Personal_Aseo> Personal_aseo {get;set;}

        public DbSet<Proveedores_Servicios> Proveedores_servicios {get;set;}

        public DbSet<Registro> Registros {get;set;}

        public DbSet<Secretarios_Despacho> Secretarios_despacho {get;set;}

        //public DbSet<Genero> generos {get;set;} sin esta linea compila (creo que se debe al ser un enumerable)

        public DbSet<Gobernacion> gobernacio {get;set;}

        public DbSet<Gobernador_Asesores> Gobernador_asesores {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog = GOBERNACION");
            }
        }




    }

}