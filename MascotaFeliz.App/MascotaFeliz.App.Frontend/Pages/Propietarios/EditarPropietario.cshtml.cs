using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class EditarPropietarioModel : PageModel {

        private readonly IRepositorioPropietario _repoPropietario;
        
        [BindProperty]
        public Propietario Propietario { get; set;} 

        public EditarPropietarioModel (IRepositorioPropietario repoPropietario) {
            this._repoPropietario = repoPropietario;
        }
        
        public IActionResult OnGet(int id) {
            Propietario = _repoPropietario.GetPropietario(id);
                return Page();
        }

        public IActionResult OnPost() {
            Propietario = _repoPropietario.UpdatePropietario(Propietario);
            return RedirectToPage("./ListaPropietario");
        }
    }        
}
