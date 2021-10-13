using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class EditarMascotaModel : PageModel {
        private readonly IRepositorioMascota _repoMascota;
        
        [BindProperty]
        public Mascota Mascota { get; set;} 

        public EditarMascotaModel (IRepositorioMascota repoMascota) {
            this._repoMascota = repoMascota;
        }
        
        public IActionResult OnGet(int id) {
            Mascota = _repoMascota.GetMascota(id);
                return Page();
        }

        public IActionResult OnPost() {
            Mascota = _repoMascota.UpdateMascota(Mascota);
            return RedirectToPage("./ListaMascota");
        }
    }
}
