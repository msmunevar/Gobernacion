using System.Collections.Generic;
using System.Linq;
using GobernaRegistroBio.App.Dominio;
using System;

namespace GobernaRegistroBio.App.Persistencia
{
    
    public class RepositorioSecretarios_Despacho : IRepositorioSecretarios_Despacho
    {
        private readonly AppContext _appContext; //Este se utiliza para traer todo lo que está en Appcontext

        public RepositorioSecretarios_Despacho(AppContext appContext)
        {
            _appContext=appContext; //Recordar el constructor.
        }
        Secretarios_Despacho IRepositorioSecretarios_Despacho.AddSecretarios_Despacho(Secretarios_Despacho secretarios_despacho)
        {
            var dependencia_adicionada= _appContext.Secretarios_despacho.Add(secretarios_despacho);
            _appContext.SaveChanges();
            return dependencia_adicionada.Entity;
        }

        Secretarios_Despacho IRepositorioSecretarios_Despacho.DeleteSecretarios_Despacho(Secretarios_Despacho secretarios_despacho)
        {
            var dependenciaEncontrada=_appContext.Secretarios_despacho.FirstOrDefault(p=> p.Id==secretarios_despacho.Id);
            if(dependenciaEncontrada==null)
                return null;
            _appContext.Secretarios_despacho.Remove(dependenciaEncontrada);
            Console.WriteLine("Se eliminó una dependencia");
            _appContext.SaveChanges();
            return dependenciaEncontrada;
        }
        IEnumerable<Secretarios_Despacho> IRepositorioSecretarios_Despacho.GetAllSecretarios_Despacho()
        {
            _appContext.SaveChanges();
            return _appContext.Secretarios_despacho;
        }
        Secretarios_Despacho IRepositorioSecretarios_Despacho.GetSecretarios_Despacho(int idsecretarios_despacho)
        {
            _appContext.SaveChanges();
            return _appContext.Secretarios_despacho.FirstOrDefault(p=> p.Id==idsecretarios_despacho);
        }
        Secretarios_Despacho IRepositorioSecretarios_Despacho.UpdateSecretarios_Despacho(Secretarios_Despacho secretarios_despacho)
        {
            var dependenciaEncontrada=_appContext.Secretarios_despacho.FirstOrDefault(p=> p.Id==secretarios_despacho.Id);
            if(dependenciaEncontrada!=null)
            {
                dependenciaEncontrada.Despacho=secretarios_despacho.Despacho;
                
                
                
              
            }
            _appContext.SaveChanges();
            return dependenciaEncontrada;
        }
    }
       
   }
  