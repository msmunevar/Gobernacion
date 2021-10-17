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
    public class EditarSecretarios_DespachoModel : PageModel
    {
        private static IRepositorioSecretarios_Despacho _appContext = new RepositorioSecretarios_Despacho(new  GobernaRegistroBio.App.Persistencia.AppContext());
        [BindProperty] // Esta etiqueta me garantiza que los datos van del backend a frontend, y viceversa.
        public Secretarios_Despacho secretarios_despacho { get; set;} 
        public IActionResult OnGet(int? secretarios_despachoId) //Este método me busca los datos de la backend para visualizarlos en la frontend.
        //El interrogante se pone para que el dato se comporte como un objeto y pueda saber si el id traido del frontend es un dato vacío o tiene algún valor.
        {
            if (secretarios_despachoId.HasValue)
            {
                secretarios_despacho = _appContext.GetSecretarios_Despacho(secretarios_despachoId.Value); //Como sé que tiene algun valor simplemente consigo ese valor, de lo contrario creo uno nuevo.
            }
            else
            {
                secretarios_despacho = new Secretarios_Despacho();
            }

            if (secretarios_despacho == null) //Si la busqueda es igual a null, entonces que me dirija a alguna página.
            {
                return RedirectToPage("./Secretarios_Despacho");
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
                if (secretarios_despacho.Id > 0) //Si el id de la persona que se editó en el Backend es mayor a cero, es porque existe, entonces se actualuza.
                {
                    _appContext.UpdateSecretarios_Despacho(secretarios_despacho);
                }
                else
                {
                    _appContext.AddSecretarios_Despacho(secretarios_despacho); //Si el Id no es mayor a cero entonces se trata de una edición.
                }
                return RedirectToPage("./Secretarios_Despacho");
            }
        }
    }

