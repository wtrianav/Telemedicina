using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class ListaVeterinarioModel : PageModel {
    private readonly IRepositorioVeterinario _repoVeterinario;
    public IEnumerable<Veterinario> Veterinarios { get; set;}
    [BindProperty]
    public Veterinario Veterinario { get; set;} 

    public ListaVeterinarioModel (IRepositorioVeterinario repoVeterinario) {
        _repoVeterinario = repoVeterinario;
    }

        public void OnGet() {
            Veterinarios = listarVeterinarios();
        }

        public ActionResult OnPost() {
            if(!ModelState.IsValid) {
                return RedirectToPage("ListaPropietario");
            }
            AddVeterinario();
            return RedirectToPage("ListaVeterinario");
        }

        public IEnumerable<Veterinario> listarVeterinarios() {
            IEnumerable<Veterinario> Veterinarios = _repoVeterinario.GetAllVeterinarios();
            return Veterinarios;
        }

        private void AddVeterinario () {

            _repoVeterinario.AddVeterinario(new Veterinario {
                Nombre = Veterinario.Nombre,
                Apellido = Veterinario.Apellido,
                TarjetaProfesionalVeterinario = Veterinario.TarjetaProfesionalVeterinario,
                NumeroTelefono = Veterinario.NumeroTelefono,
                Email = Veterinario.Email
            });
        }

        public IActionResult OnGetDeleteVeterinario(int Id) {
            _repoVeterinario.DeleteVeterinario(Id);
            return Redirect("ListaVeterinario");
        }
    }
}
