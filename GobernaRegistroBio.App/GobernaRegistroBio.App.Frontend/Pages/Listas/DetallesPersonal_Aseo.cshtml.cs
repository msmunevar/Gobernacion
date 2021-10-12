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
    public class DetallesPersonal_AseoModel : PageModel
    {
        private static IRepositorioPersonal_Aseo _appContext = new RepositorioPersonal_Aseo(new  GobernaRegistroBio.App.Persistencia.AppContext());
        [BindProperty]
        public Personal_Aseo personal_aseo { get; set;} 
        
        public IActionResult OnGet(int personal_aseoId)
        {
            personal_aseo= _appContext.GetPersonal_Aseo(personal_aseoId);
            if(personal_aseo==null)
            {
                return RedirectToPage("./Personal_Aseo");
            }else{
                return Page();
            }
        }
    }
}
