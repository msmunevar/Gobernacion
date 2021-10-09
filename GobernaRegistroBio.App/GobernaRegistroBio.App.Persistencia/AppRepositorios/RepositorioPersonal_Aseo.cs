
using System.Collections.Generic;
using System.Linq;
using GobernaRegistroBio.App.Dominio;
using System;

namespace GobernaRegistroBio.App.Persistencia
{
    
    public class RepositorioPersonal_Aseo : IRepositorioPersonal_Aseo
    {
        private readonly AppContext _appContext; //Este se utiliza para traer todo lo que está en Appcontext

        public RepositorioPersonal_Aseo(AppContext appContext)
        {
            _appContext=appContext; //Recordar el constructor.
        }
        Personal_Aseo IRepositorioPersonal_Aseo.AddPersonal_Aseo(Personal_Aseo personal_aseo )
        {
            var persona_adicionada= _appContext.Personal_aseo.Add(personal_aseo);
            _appContext.SaveChanges();
            return persona_adicionada.Entity;
        }

        void IRepositorioPersonal_Aseo.DeletePersonal_Aseo(int idpersonal_Aseo)
        {
            var personaEncontrada=_appContext.Personal_aseo.FirstOrDefault(p=> p.Id==idpersonal_Aseo);
            if(personaEncontrada!=null)
                return;
            _appContext.Personal_aseo.Remove(personaEncontrada);
            Console.WriteLine("Se eliminó una persona del aseo");
            _appContext.SaveChanges();
        }
        IEnumerable<Personal_Aseo> IRepositorioPersonal_Aseo.GetAllPersonal_Aseo()
        {
            return _appContext.Personal_aseo;
        }
        Personal_Aseo IRepositorioPersonal_Aseo.GetPersonal_Aseo(int idpersonal_Aseo)
        {
            return _appContext.Personal_aseo.FirstOrDefault(p=> p.Id==idpersonal_Aseo);
        }
        Personal_Aseo IRepositorioPersonal_Aseo.UpdatePersonal_Aseo(Personal_Aseo personal_aseo)
        {
            var personaEncontrada=_appContext.Personal_aseo.FirstOrDefault(p=> p.Id==personal_aseo.Id);
            if(personaEncontrada!=null)
            {
                personaEncontrada.Nombre=personal_aseo.Nombre;
                personaEncontrada.Apellidos=personal_aseo.Apellidos;
                personaEncontrada.Identificacion=personal_aseo.Identificacion;
                personaEncontrada.Edad=personal_aseo.Edad;
                personaEncontrada.Estado=personal_aseo.Estado;
                personaEncontrada.Direccion=personal_aseo.Direccion;
                personaEncontrada.Telefono=personal_aseo.Telefono;
                personaEncontrada.Rol=personal_aseo.Rol;
                personaEncontrada.Genero=personal_aseo.Genero;
                personaEncontrada.Turno_Servicio=personal_aseo.Turno_Servicio;
                
                _appContext.SaveChanges();
            }
            return personaEncontrada;
        }
    }
       
   }
   