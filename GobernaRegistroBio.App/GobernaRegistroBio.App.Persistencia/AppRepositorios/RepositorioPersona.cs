using System.Collections.Generic;
using GobernaRegistroBio.App.Dominio;
using System.Ling;


namespace GobernaRegistroBio.App.Persistencia
{
    
    public class RepositorioPersona : IRepositorioPersona
    {
        private readonly AppContext _appContext; //Este se utiliza para traer todo lo que está en Appcontext

        public RepositorioPersona(AppContext appContext)
        {
            _appContext=appContext; //Recordar el constructor.
        }

        Persona IRepositorioPersona.AddPersona(Persona persona)
        {
            var personaa_adicionada= _appContext.Persona.Add(persona);
            _appContext.SaveChanges();
            return persona_adicionado.Entity;
        }
        void IRepositorioPersona.DeletePersona(int idPersona)
        {
            var personaEncontrada=_appContext.Persona.FirstOrDefault(p=> p.Id==idPersona);
            if(personaEncontrada!=null)
                return;
            _appContext.Persona.Remove(personaEncontrada);
            _appContext.SaveChanges():
        }
        IEnumerable<Persona> IRepositorioPersona.GetAllPersona()
        {
            return _appContext.Persona;
        }
        Persona IRepositorioPersona.GetPersona(int Persona)
        {
            return personaEncontrada=_appContext.Persona.FirstOrDefault(p=> p.Id==idPersona);
        }
        Persona IRepositorioPersona.UpdatePersona(Persona persona)
        {
            var personaEncontrada=_appContext.Persona.FirstOrDefault(p=> p.Id==persona.Id);
            if(personaEncontrada!=null)
            {
                personaEncontrada.Nombre=persona.Nombre;
                personaEncontrada.Apellidos=persona.Apellidos;
                personaEncontrada.Identificacion=persona.Identificacion;
                personaEncontrada.Edad=persona.Edad;
                personaEncontrada.Estado=persona.Estado;
                personaEncontrada.Direccion=persona.Direccion;
                personaEncontrada.Telefono=persona.Telefono;
                personaEncontrada.Rol=persona.Rol;
                personaEncontrada.Genero=persona.Rol;
                
                _appContext.SaveChanges();
            }
            return personaEncontrada
        }
    }
   }
}