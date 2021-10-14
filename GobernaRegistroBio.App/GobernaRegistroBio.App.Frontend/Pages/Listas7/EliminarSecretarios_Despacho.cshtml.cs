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
    public class EliminarSecretarios_DespachoModel : PageModel
    {
        private static IRepositorioSecretarios_Despacho _appContext = new RepositorioSecretarios_Despacho(new  GobernaRegistroBio.App.Persistencia.AppContext());
        [BindProperty]
        public Secretarios_Despacho secretarios_despacho{get;set;}

        public IActionResult OnGet(int secretarios_despachoId)
        {
            secretarios_despacho= _appContext.GetSecretarios_Despacho(secretarios_despachoId);
            return Page();
        }
        public IActionResult OnPost()
        {
            _appContext.DeleteSecretarios_Despacho(secretarios_despacho);
            return RedirectToPage("./Secretarios_Despacho");
        }
    }
}
