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
    public class Gobernador_AsesoresModel : PageModel
    {
        private static IRepositorioGobernador_Asesores _appContext = new RepositorioGobernador_Asesores(new  GobernaRegistroBio.App.Persistencia.AppContext());
        public IEnumerable<Gobernador_Asesores> GObernador_Asesores{get;set;} //Esta es el backend
        public Gobernador_Asesores gobernador_asesores{get;set;} //Este es la interfaz
        public void OnGet()
        {
            GObernador_Asesores=_appContext.GetAllGobernador_Asesores();
        }
    }
}
