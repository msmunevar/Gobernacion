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
    public class PersonasModel : PageModel
    {
        private static IRepositorioPersona _appContext = new RepositorioPersona(new  GobernaRegistroBio.App.Persistencia.AppContext());
        public IEnumerable<Persona> Personas{get;set;} //Esta es el backend
        public Persona persona{get;set;} //Este es la interfaz
        public void OnGet()
        {
            Personas=_appContext.GetAllPersona();
        }
    }
}
