
using System.Collections.Generic;
using System.Linq;
using GobernaRegistroBio.App.Dominio;
using System;

namespace GobernaRegistroBio.App.Persistencia
{
    
    public class RepositorioDependencia : IRepositorioDependencia
    {
        private readonly AppContext _appContext; //Este se utiliza para traer todo lo que está en Appcontext

        public RepositorioDependencia(AppContext appContext)
        {
            _appContext=appContext; //Recordar el constructor.
        }
        Dependencia IRepositorioDependencia.AddDependencia(Dependencia dependencia)
        {
            var dependencia_adicionada= _appContext.Dependencias.Add(dependencia);
            _appContext.SaveChanges();
            return dependencia_adicionada.Entity;
        }

        Dependencia IRepositorioDependencia.DeleteDependencia(Dependencia dependencia)
        {
            var dependenciaEncontrada=_appContext.Dependencias.FirstOrDefault(p=> p.Id==dependencia.Id);
            if(dependenciaEncontrada==null)
                return null;
            _appContext.Dependencias.Remove(dependenciaEncontrada);
            Console.WriteLine("Se eliminó una dependencia");
            _appContext.SaveChanges();
            return dependenciaEncontrada;
        }
        IEnumerable<Dependencia> IRepositorioDependencia.GetAllDependencia()
        {
            _appContext.SaveChanges();
            return _appContext.Dependencias;
        }
        Dependencia IRepositorioDependencia.GetDependencia(int iddependencia)
        {
            _appContext.SaveChanges();
            return _appContext.Dependencias.FirstOrDefault(p=> p.Id==iddependencia);
        }
        Dependencia IRepositorioDependencia.UpdateDependencia(Dependencia dependencia)
        {
            var dependenciaEncontrada=_appContext.Dependencias.FirstOrDefault(p=> p.Id==dependencia.Id);
            if(dependenciaEncontrada!=null)
            {
                dependenciaEncontrada.Ubicacion=dependencia.Ubicacion;
                dependenciaEncontrada.Aforo_PorDependencia=dependencia.Aforo_PorDependencia;
                
                
              
            }
            _appContext.SaveChanges();
            return dependenciaEncontrada;
        }
    }
       
   }
  