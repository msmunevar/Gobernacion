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
    public class DetallesGobernacionModel : PageModel
    {
        private static IRepositorioGobernacion _appContext = new RepositorioGobernacion(new  GobernaRegistroBio.App.Persistencia.AppContext());
        [BindProperty]
        public Gobernacion gobernacion { get; set;} 
        
        public IActionResult OnGet(int gobernacionId)
        {
            gobernacion= _appContext.GetGobernacion(gobernacionId);
            if(gobernacion==null)
            {
                return RedirectToPage("./Gobernacion");
            }else{
                return Page();
            }
        }
    }
}
