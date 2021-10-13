
using System.Collections.Generic;
using System.Linq;
using GobernaRegistroBio.App.Dominio;
using System;

namespace GobernaRegistroBio.App.Persistencia
{
    
    public class RepositorioGobernador_Asesores : IRepositorioGobernador_Asesores
    {
        private readonly AppContext _appContext; //Este se utiliza para traer todo lo que está en Appcontext

        public RepositorioGobernador_Asesores(AppContext appContext)
        {
            _appContext=appContext; //Recordar el constructor.
        }
        Gobernador_Asesores IRepositorioGobernador_Asesores.AddGobernador_Asesores(Gobernador_Asesores gobernador_asesores)
        {
            var dependencia_adicionada= _appContext.Gobernador_asesores.Add(gobernador_asesores);
            _appContext.SaveChanges();
            return dependencia_adicionada.Entity;
        }

        Gobernador_Asesores IRepositorioGobernador_Asesores.DeleteGobernador_Asesores(Gobernador_Asesores gobernador_asesores)
        {
            var dependenciaEncontrada=_appContext.Gobernador_asesores.FirstOrDefault(p=> p.Id==gobernador_asesores.Id);
            if(dependenciaEncontrada==null)
                return null;
            _appContext.Gobernador_asesores.Remove(dependenciaEncontrada);
            Console.WriteLine("Se eliminó una dependencia");
            _appContext.SaveChanges();
            return dependenciaEncontrada;
        }
        IEnumerable<Gobernador_Asesores> IRepositorioGobernador_Asesores.GetAllGobernador_Asesores()
        {
            _appContext.SaveChanges();
            return _appContext.Gobernador_asesores;
        }
        Gobernador_Asesores IRepositorioGobernador_Asesores.GetGobernador_Asesores(int idgobernador_asesores)
        {
            _appContext.SaveChanges();
            return _appContext.Gobernador_asesores.FirstOrDefault(p=> p.Id==idgobernador_asesores);
        }
        Gobernador_Asesores IRepositorioGobernador_Asesores.UpdateGobernador_Asesores(Gobernador_Asesores gobernador_asesores)
        {
            var dependenciaEncontrada=_appContext.Gobernador_asesores.FirstOrDefault(p=> p.Id==gobernador_asesores.Id);
            if(dependenciaEncontrada!=null)
            {
                dependenciaEncontrada.Oficinas_Visitadas=gobernador_asesores.Oficinas_Visitadas;
                
                
                
              
            }
            _appContext.SaveChanges();
            return dependenciaEncontrada;
        }
    }
       
   }
  