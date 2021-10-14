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
    public class RegistroModel : PageModel
    {
        private static IRepositorioRegistro _appContext = new RepositorioRegistro(new  GobernaRegistroBio.App.Persistencia.AppContext());
        public IEnumerable<Registro> REgistro{get;set;} //Esta es el backend
        public Registro registro{get;set;} //Este es la interfaz
        public void OnGet()
        {
            REgistro=_appContext.GetAllRegistro();
        }
    }
}
