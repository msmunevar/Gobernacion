using System.Collections.Generic;
using System.Linq;
using GobernaRegistroBio.App.Dominio;
using System;

namespace GobernaRegistroBio.App.Persistencia
{
    
    public class RepositorioProveedores_Servicios : IRepositorioProveedores_Servicios
    {
        private readonly AppContext _appContext; //Este se utiliza para traer todo lo que está en Appcontext

        public RepositorioProveedores_Servicios(AppContext appContext)
        {
            _appContext=appContext; //Recordar el constructor.
        }
        Proveedores_Servicios IRepositorioProveedores_Servicios.AddProveedores_Servicios(Proveedores_Servicios proveedores_servicios)
        {
            var dependencia_adicionada= _appContext.Proveedores_servicios.Add(proveedores_servicios);
            _appContext.SaveChanges();
            return dependencia_adicionada.Entity;
        }

        Proveedores_Servicios IRepositorioProveedores_Servicios.DeleteProveedores_Servicios(Proveedores_Servicios proveedores_servicios)
        {
            var dependenciaEncontrada=_appContext.Proveedores_servicios.FirstOrDefault(p=> p.Id==proveedores_servicios.Id);
            if(dependenciaEncontrada==null)
                return null;
            _appContext.Proveedores_servicios.Remove(dependenciaEncontrada);
            Console.WriteLine("Se eliminó una dependencia");
            _appContext.SaveChanges();
            return dependenciaEncontrada;
        }
        IEnumerable<Proveedores_Servicios> IRepositorioProveedores_Servicios.GetAllProveedores_Servicios()
        {
            _appContext.SaveChanges();
            return _appContext.Proveedores_servicios;
        }
        Proveedores_Servicios IRepositorioProveedores_Servicios.GetProveedores_Servicios(int idproveedores_servicios)
        {
            _appContext.SaveChanges();
            return _appContext.Proveedores_servicios.FirstOrDefault(p=> p.Id==idproveedores_servicios);
        }
        Proveedores_Servicios IRepositorioProveedores_Servicios.UpdateProveedores_Servicios(Proveedores_Servicios proveedores_servicios)
        {
            var dependenciaEncontrada=_appContext.Proveedores_servicios.FirstOrDefault(p=> p.Id==proveedores_servicios.Id);
            if(dependenciaEncontrada!=null)
            {
                dependenciaEncontrada.Servicio_Realizado=proveedores_servicios.Servicio_Realizado;
                dependenciaEncontrada.Unidad_Servicio=proveedores_servicios.Unidad_Servicio;
                
                
              
            }
            _appContext.SaveChanges();
            return dependenciaEncontrada;
        }
    }
       
   }