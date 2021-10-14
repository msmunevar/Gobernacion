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
    public class GobernacionModel : PageModel
    {
        private static IRepositorioGobernacion _appContext = new RepositorioGobernacion(new  GobernaRegistroBio.App.Persistencia.AppContext());
        public IEnumerable<Gobernacion> GObernacion{get;set;} //Esta es el backend
        public Gobernacion gobernacion{get;set;} //Este es la interfaz
        public void OnGet()
        {
            GObernacion=_appContext.GetAllGobernacion();
        }
    }
}
