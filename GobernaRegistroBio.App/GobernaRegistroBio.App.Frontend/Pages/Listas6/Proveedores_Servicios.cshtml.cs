using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GobernaRegistroBio.App.Persistencia;
using GobernaRegistroBio.App.Dominio;

namespace GobernaRegistroBio.App.Frontend.Pages
{
    public class Proveedores_ServiciosModel : PageModel
    {
        private static IRepositorioProveedores_Servicios _appContext = new RepositorioProveedores_Servicios(new  GobernaRegistroBio.App.Persistencia.AppContext());
        public IEnumerable<Proveedores_Servicios> proveedores_Servicios{get;set;} //Esta es el backend
        public Proveedores_Servicios proveedores_servicios{get;set;} //Este es la interfaz
        public void OnGet()
        {
            proveedores_Servicios=_appContext.GetAllProveedores_Servicios();
        }
    }
}
