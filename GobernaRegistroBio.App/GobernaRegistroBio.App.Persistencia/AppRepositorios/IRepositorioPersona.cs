using System.Collections.Generic;
using GobernaRegistroBio.App.Dominio;

namespace GobernaRegistroBio.App.Persistencia
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetAllPersona();//Me retorna una lista de pacientes
        Persona AddPersona(Persona persona);
        Persona UpdatePersona(Persona persona);
        void DeletePersona(int idpersona);
        Persona GetPersona(int idpersona); //Encabezados de métodos pero no tienen implementacion




    }
}