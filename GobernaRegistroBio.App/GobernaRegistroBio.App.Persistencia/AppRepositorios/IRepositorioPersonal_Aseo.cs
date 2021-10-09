using System.Collections.Generic;
using GobernaRegistroBio.App.Dominio;

namespace GobernaRegistroBio.App.Persistencia
{
    public interface IRepositorioPersonal_Aseo
    {
        IEnumerable<Personal_Aseo> GetAllPersonal_Aseo();//Me retorna una lista de personal de aseo
        Personal_Aseo AddPersonal_Aseo(Personal_Aseo personal_aseo);
        Personal_Aseo UpdatePersonal_Aseo(Personal_Aseo personal_aseo);
        void DeletePersonal_Aseo(int idpersonal_Aseo);
        Personal_Aseo GetPersonal_Aseo(int idpersonal_Aseo); //Encabezados de métodos pero no tienen implementacion




    }
}