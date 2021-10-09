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
    public class DetallesrPersonasModel : PageModel
    {
        private static IRepositorioPersona _appContext = new RepositorioPersona(new  GobernaRegistroBio.App.Persistencia.AppContext());
        [BindProperty]
        public Persona persona { get; set;} 
        
        public IActionResult OnGet(int personaId)
        {
            persona= _appContext.GetPersona(personaId);
            if(persona==null)
            {
                return RedirectToPage();
            }else{
                return Page();
            }
        }
    }
}
