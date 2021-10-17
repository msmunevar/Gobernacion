using System.Collections.Generic;
using System.Linq;
using GobernaRegistroBio.App.Dominio;
using System;

namespace GobernaRegistroBio.App.Persistencia
{
    
    public class RepositorioRegistro : IRepositorioRegistro
    {
        private readonly AppContext _appContext; //Este se utiliza para traer todo lo que está en Appcontext

        public RepositorioRegistro(AppContext appContext)
        {
            _appContext=appContext; //Recordar el constructor.
        }
        Registro IRepositorioRegistro.AddRegistro(Registro registro)
        {
            var dependencia_adicionada= _appContext.Registros.Add(registro);
            _appContext.SaveChanges();
            return dependencia_adicionada.Entity;
        }

        Registro IRepositorioRegistro.DeleteRegistro(Registro registro)
        {
            var dependenciaEncontrada=_appContext.Registros.FirstOrDefault(p=> p.Id==registro.Id);
            if(dependenciaEncontrada==null)
                return null;
            _appContext.Registros.Remove(dependenciaEncontrada);
            Console.WriteLine("Se eliminó una dependencia");
            _appContext.SaveChanges();
            return dependenciaEncontrada;
        }
        IEnumerable<Registro> IRepositorioRegistro.GetAllRegistro()
        {
            _appContext.SaveChanges();
            return _appContext.Registros;
        }
        Registro IRepositorioRegistro.GetRegistro(int idregistro)
        {
            _appContext.SaveChanges();
            return _appContext.Registros.FirstOrDefault(p=> p.Id==idregistro);
        }
        Registro IRepositorioRegistro.UpdateRegistro(Registro registro)
        {
            var dependenciaEncontrada=_appContext.Registros.FirstOrDefault(p=> p.Id==registro.Id);
            if(dependenciaEncontrada!=null)
            {
                dependenciaEncontrada.Fecha_Diagnostico=registro.Fecha_Diagnostico;
                dependenciaEncontrada.Sintomas=registro.Sintomas;
                dependenciaEncontrada.Tiempo_Aislamiento=registro.Tiempo_Aislamiento;
                dependenciaEncontrada.Autoriza_Ingreso=registro.Autoriza_Ingreso;
                dependenciaEncontrada.persona=registro.persona;
                
                
              
            }
            _appContext.SaveChanges();
            return dependenciaEncontrada;
        }
    }
       
   }