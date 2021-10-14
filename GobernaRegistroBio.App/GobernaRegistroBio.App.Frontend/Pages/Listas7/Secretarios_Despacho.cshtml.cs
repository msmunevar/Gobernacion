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
    public class Secretarios_DespachoModel : PageModel
    {
        private static IRepositorioSecretarios_Despacho _appContext = new RepositorioSecretarios_Despacho(new  GobernaRegistroBio.App.Persistencia.AppContext());
        public IEnumerable<Secretarios_Despacho> SEcretarios_Despacho{get;set;} //Esta es el backend
        public Secretarios_Despacho secretarios_despacho{get;set;} //Este es la interfaz
        public void OnGet()
        {
            SEcretarios_Despacho=_appContext.GetAllSecretarios_Despacho();
        }
    }
}
