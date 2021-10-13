using System.Collections.Generic;
using GobernaRegistroBio.App.Dominio;

namespace GobernaRegistroBio.App.Persistencia
{
    public interface IRepositorioProveedores_Servicios
    {
        IEnumerable<Proveedores_Servicios> GetAllProveedores_Servicios();
        Proveedores_Servicios AddProveedores_Servicios(Proveedores_Servicios proveedores_servicios);
        Proveedores_Servicios UpdateProveedores_Servicios(Proveedores_Servicios proveedores_servicios);
        Proveedores_Servicios DeleteProveedores_Servicios(Proveedores_Servicios proveedores_servicios);
        Proveedores_Servicios GetProveedores_Servicios(int idproveedores_servicios); 



    }
}