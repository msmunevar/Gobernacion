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
    public class EditarGobernacionModel : PageModel
    {
        private static IRepositorioGobernacion _appContext = new RepositorioGobernacion(new  GobernaRegistroBio.App.Persistencia.AppContext());
        [BindProperty] // Esta etiqueta me garantiza que los datos van del backend a frontend, y viceversa.
        public Gobernacion gobernacion { get; set;} 
        public IActionResult OnGet(int? gobernacionId) //Este método me busca los datos de la backend para visualizarlos en la frontend.
        //El interrogante se pone para que el dato se comporte como un objeto y pueda saber si el id traido del frontend es un dato vacío o tiene algún valor.
        {
            if (gobernacionId.HasValue)
            {
                gobernacion = _appContext.GetGobernacion(gobernacionId.Value); //Como sé que tiene algun valor simplemente consigo ese valor, de lo contrario creo uno nuevo.
            }
            else
            {
                gobernacion = new Gobernacion();
            }

            if (gobernacion == null) //Si la busqueda es igual a null, entonces que me dirija a alguna página.
            {
                return RedirectToPage("./Gobernacion");
            }
            return Page();
        }

        public IActionResult OnPost() //Este método refresca los datos, es decir, me lleva los datos que edité. 
        {
            /*if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {*/
                if (gobernacion.Id > 0) //Si el id de la persona que se editó en el Backend es mayor a cero, es porque existe, entonces se actualuza.
                {
                    _appContext.UpdateGobernacion(gobernacion);
                }
                else
                {
                    _appContext.AddGobernacion(gobernacion); //Si el Id no es mayor a cero entonces se trata de una edición.
                }
                return RedirectToPage("./Gobernacion");
            }
        }
    }

