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
    public class DetallesDependenciaModel : PageModel
    {
        private static IRepositorioDependencia _appContext = new RepositorioDependencia(new  GobernaRegistroBio.App.Persistencia.AppContext());
        [BindProperty]
        public Dependencia dependencia { get; set;} 
        
        public IActionResult OnGet(int dependenciaId)
        {
            dependencia= _appContext.GetDependencia(dependenciaId);
            if(dependencia==null)
            {
                return RedirectToPage("./Dependencia");
            }else{
                return Page();
            }
        }
    }
}
