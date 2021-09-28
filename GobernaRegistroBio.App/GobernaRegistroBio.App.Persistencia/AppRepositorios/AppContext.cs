using Microsoft.EntityFrameworkCore;
using GobernaRegistroBio.App.Dominio;

namespace GobernaRegistroBio.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> personas {get;set;}
    }

}