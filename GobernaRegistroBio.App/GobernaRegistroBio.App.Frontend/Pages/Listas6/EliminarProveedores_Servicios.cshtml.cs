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
    public class EliminarProveedores_ServiciosModel : PageModel
    {
        private static IRepositorioProveedores_Servicios _appContext = new RepositorioProveedores_Servicios(new  GobernaRegistroBio.App.Persistencia.AppContext());
        [BindProperty]
        public Proveedores_Servicios proveedores_servicios{get;set;}

        public IActionResult OnGet(int proveedores_serviciosId)
        {
            proveedores_servicios= _appContext.GetProveedores_Servicios(proveedores_serviciosId);
            return Page();
        }
        public IActionResult OnPost()
        {
            _appContext.DeleteProveedores_Servicios(proveedores_servicios);
            return RedirectToPage("./Proveedores_Servicios");
        }
    }
}
