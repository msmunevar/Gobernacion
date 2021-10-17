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
    public class EliminarGobernacionModel : PageModel
    {
        private static IRepositorioGobernacion _appContext = new RepositorioGobernacion(new  GobernaRegistroBio.App.Persistencia.AppContext());
        [BindProperty]
        public Gobernacion gobernacion{get;set;}

        public IActionResult OnGet(int gobernacionId)
        {
            gobernacion= _appContext.GetGobernacion(gobernacionId);
            return Page();
        }
        public IActionResult OnPost()
        {
            _appContext.DeleteGobernacion(gobernacion);
            return RedirectToPage("./Gobernacion");
        }
    }
}
