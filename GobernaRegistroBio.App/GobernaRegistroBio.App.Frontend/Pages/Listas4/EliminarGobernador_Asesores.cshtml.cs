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
    public class EliminarGobernador_AsesoresModel : PageModel
    {
        private static IRepositorioGobernador_Asesores _appContext = new RepositorioGobernador_Asesores(new  GobernaRegistroBio.App.Persistencia.AppContext());
        [BindProperty]
        public Gobernador_Asesores gobernador_asesores{get;set;}

        public IActionResult OnGet(int gobernador_asesoresId)
        {
            gobernador_asesores= _appContext.GetGobernador_Asesores(gobernador_asesoresId);
            return Page();
        }
        public IActionResult OnPost()
        {
            _appContext.DeleteGobernador_Asesores(gobernador_asesores);
            return RedirectToPage("./Gobernador_Asesores");
        }
    }
}
