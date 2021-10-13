using System.Collections.Generic;
using GobernaRegistroBio.App.Dominio;

namespace GobernaRegistroBio.App.Persistencia
{
    public interface IRepositorioGobernador_Asesores
    {
        IEnumerable<Gobernador_Asesores> GetAllGobernador_Asesores();
        Gobernador_Asesores AddGobernador_Asesores(Gobernador_Asesores gobernador_asesores);
        Gobernador_Asesores UpdateGobernador_Asesores(Gobernador_Asesores gobernador_asesores);
        Gobernador_Asesores DeleteGobernador_Asesores(Gobernador_Asesores gobernador_asesores);
        Gobernador_Asesores GetGobernador_Asesores(int idgobernador_asesores); 



    }
}