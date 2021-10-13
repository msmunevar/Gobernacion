using System.Collections.Generic;
using GobernaRegistroBio.App.Dominio;

namespace GobernaRegistroBio.App.Persistencia
{
    public interface IRepositorioSecretarios_Despacho
    {
        IEnumerable<Secretarios_Despacho> GetAllSecretarios_Despacho();
        Secretarios_Despacho AddSecretarios_Despacho(Secretarios_Despacho secretarios_despacho);
        Secretarios_Despacho UpdateSecretarios_Despacho(Secretarios_Despacho secretarios_despacho);
        Secretarios_Despacho DeleteSecretarios_Despacho(Secretarios_Despacho secretarios_despacho);
        Secretarios_Despacho GetSecretarios_Despacho(int idsecretarios_despacho); 



    }
}