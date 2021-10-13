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
    public class DependenciaModel : PageModel
    {
        private static IRepositorioDependencia _appContext = new RepositorioDependencia(new  GobernaRegistroBio.App.Persistencia.AppContext());
        public IEnumerable<Dependencia> DEpendencia{get;set;} //Esta es el backend
        public Dependencia dependencia{get;set;} //Este es la interfaz
        public void OnGet()
        {
            DEpendencia=_appContext.GetAllDependencia();
        }
    }
}
