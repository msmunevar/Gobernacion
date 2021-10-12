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
    public class Personal_AseoModel : PageModel
    {
        private static IRepositorioPersonal_Aseo _appContext = new RepositorioPersonal_Aseo(new  GobernaRegistroBio.App.Persistencia.AppContext());
        public IEnumerable<Personal_Aseo> personal_Aseo{get;set;} //Esta es el backend
        public Personal_Aseo personal_aseo{get;set;} //Este es la interfaz
        public void OnGet()
        {
            personal_Aseo=_appContext.GetAllPersonal_Aseo();
        }
    }
}
