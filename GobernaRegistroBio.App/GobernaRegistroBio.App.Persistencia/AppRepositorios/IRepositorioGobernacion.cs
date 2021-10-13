using System.Collections.Generic;
using GobernaRegistroBio.App.Dominio;

namespace GobernaRegistroBio.App.Persistencia
{
    public interface IRepositorioGobernacion
    {
        IEnumerable<Gobernacion> GetAllGobernacion();
        Gobernacion AddGobernacion(Gobernacion gobernacion);
        Gobernacion UpdateGobernacion(Gobernacion gobernacion);
        Gobernacion DeleteGobernacion(Gobernacion gobernacion);
        Gobernacion GetAllGobernacion(int idgobernacion); 



    }
}