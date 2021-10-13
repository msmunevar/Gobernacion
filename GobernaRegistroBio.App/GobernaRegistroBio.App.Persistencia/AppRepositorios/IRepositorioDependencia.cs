using System.Collections.Generic;
using GobernaRegistroBio.App.Dominio;

namespace GobernaRegistroBio.App.Persistencia
{
    public interface IRepositorioDependencia
    {
        IEnumerable<Dependencia> GetAllDependencia();
        Dependencia AddDependencia(Dependencia dependencia);
        Dependencia UpdateDependencia(Dependencia dependencia);
        Dependencia DeleteDependencia(Dependencia dependencia);
        Dependencia GetDependencia(int iddependencia); 



    }
}