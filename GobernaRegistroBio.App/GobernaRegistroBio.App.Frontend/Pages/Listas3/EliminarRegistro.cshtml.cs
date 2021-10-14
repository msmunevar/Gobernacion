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
    public class EliminarRegistroModel : PageModel
    {
        private static IRepositorioRegistro _appContext = new RepositorioRegistro(new  GobernaRegistroBio.App.Persistencia.AppContext());
        [BindProperty]
        public Registro registro{get;set;}

        public IActionResult OnGet(int registroId)
        {
            registro= _appContext.GetRegistro(registroId);
            return Page();
        }
        public IActionResult OnPost()
        {
            _appContext.DeleteRegistro(registro);
            return RedirectToPage("./Registro");
        }
    }
}
