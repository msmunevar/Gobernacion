using System.Collections.Generic;
using GobernaRegistroBio.App.Dominio;

namespace GobernaRegistroBio.App.Persistencia
{
    public interface IRepositorioRegistro
    {
        IEnumerable<Registro> GetAllRegistro();
        Registro AddRegistro(Registro registro);
        Registro UpdateRegistro(Registro registro);
        Registro DeleteRegistro(Registro registro);
        Registro GetRegistro(int idregistro); 



    }
}