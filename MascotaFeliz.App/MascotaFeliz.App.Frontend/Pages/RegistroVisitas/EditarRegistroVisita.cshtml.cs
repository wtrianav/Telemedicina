using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MascotaFeliz.App.Frontend.Pages {
    public class EditarRegistroVisitaModel : PageModel {
        private readonly IRepositorioRegistroVisita _repoRegistroVisita;
        
        [BindProperty]
        public RegistroVisita RegistroVisita { get; set;} 

        public EditarRegistroVisitaModel (IRepositorioRegistroVisita repoRegistroVisita) {
            this._repoRegistroVisita = repoRegistroVisita;
        }
        
        public IActionResult OnGet(int id) {
            RegistroVisita = _repoRegistroVisita.GetRegistroVisita(id);
                return Page();
        }

        public IActionResult OnPost() {
            RegistroVisita = _repoRegistroVisita.UpdateRegistroVisita(RegistroVisita);
            return RedirectToPage("./ListaRegistroVisita");
        }
    }
}
