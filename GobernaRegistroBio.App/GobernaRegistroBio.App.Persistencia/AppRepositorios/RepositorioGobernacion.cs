using System.Collections.Generic;
using System.Linq;
using GobernaRegistroBio.App.Dominio;
using System;

namespace GobernaRegistroBio.App.Persistencia
{
    
    public class RepositorioGobernacion : IRepositorioGobernacion
    {
        private readonly AppContext _appContext; 
        public RepositorioGobernacion(AppContext appContext)
        {
            _appContext=appContext; //Recordar el constructor.
        }
        Gobernacion IRepositorioGobernacion.AddGobernacion(Gobernacion gobernacion)
        {
            var dependencia_adicionada= _appContext.gobernacio.Add(gobernacion);
            _appContext.SaveChanges();
            return dependencia_adicionada.Entity;
        }

        Gobernacion IRepositorioGobernacion.DeleteGobernacion(Gobernacion gobernacion)
        {
            var dependenciaEncontrada=_appContext.gobernacio.FirstOrDefault(p=> p.Id==gobernacion.Id);
            if(dependenciaEncontrada==null)
                return null;
            _appContext.gobernacio.Remove(dependenciaEncontrada);
            Console.WriteLine("Se eliminó gobernación");
            _appContext.SaveChanges();
            return dependenciaEncontrada;
        }
        IEnumerable<Gobernacion> IRepositorioGobernacion.GetAllGobernacion()
        {
            _appContext.SaveChanges();
            return _appContext.gobernacio;
        }
        Gobernacion IRepositorioGobernacion.GetGobernacion(int idgobernacion)
        {
            _appContext.SaveChanges();
            return _appContext.gobernacio.FirstOrDefault(p=> p.Id==idgobernacion);
        }
        Gobernacion IRepositorioGobernacion.UpdateGobernacion(Gobernacion gobernacion)
        {
            var dependenciaEncontrada=_appContext.gobernacio.FirstOrDefault(p=> p.Id==gobernacion.Id);
            if(dependenciaEncontrada!=null)
            {
                dependenciaEncontrada.Dependencias=gobernacion.Dependencias;
                dependenciaEncontrada.Aforo=gobernacion.Aforo;
                
                
              
            }
            _appContext.SaveChanges();
            return dependenciaEncontrada;
        }
    }
       
   }