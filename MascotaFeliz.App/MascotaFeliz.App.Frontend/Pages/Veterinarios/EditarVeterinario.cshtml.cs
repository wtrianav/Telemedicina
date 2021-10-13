using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class EditarVeterinarioModel : PageModel {
        private readonly IRepositorioVeterinario _repoVeterinario;
        
        [BindProperty]
        public Veterinario Veterinario { get; set;} 

        public EditarVeterinarioModel (IRepositorioVeterinario repoVeterinario) {
            this._repoVeterinario = repoVeterinario;
        }
        
        public IActionResult OnGet(int id) {
            Veterinario = _repoVeterinario.GetVeterinario(id);
                return Page();
        }

        public IActionResult OnPost() {
            Veterinario = _repoVeterinario.UpdateVeterinario(Veterinario);
            return RedirectToPage("./ListaVeterinario");
        }
    }
}
