using System.Collections.Generic;
using System.Linq;
using GobernaRegistroBio.App.Dominio;
using System;

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
            var persona_adicionada= _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return persona_adicionada.Entity;
        }

        void IRepositorioPersona.DeletePersona(int idpersona)
        {
            var personaEncontrada=_appContext.Personas.FirstOrDefault(p=> p.Id==idpersona);
            if(personaEncontrada!=null)
                return;
            _appContext.Personas.Remove(personaEncontrada);
            _appContext.SaveChanges();
        }
        IEnumerable<Persona> IRepositorioPersona.GetAllPersona()
        {
            return _appContext.Personas;
        }
        Persona IRepositorioPersona.GetPersona(int idpersona)
        {
            return _appContext.Personas.FirstOrDefault(p=> p.Id==idpersona);
        }
        Persona IRepositorioPersona.UpdatePersona(Persona persona)
        {
            var personaEncontrada=_appContext.Personas.FirstOrDefault(p=> p.Id==persona.Id);
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
                personaEncontrada.Genero=persona.Genero;
                
                _appContext.SaveChanges();
            }
            return personaEncontrada;
        }
    }
       
   }