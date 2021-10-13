using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class ListaMascotaModel : PageModel {
    
    private readonly IRepositorioMascota _repoMascota;
    public IEnumerable<Mascota> Mascotas { get; set;}
    [BindProperty]
    public Mascota Mascota { get; set;} 

    public ListaMascotaModel (IRepositorioMascota repoMascota) {
        _repoMascota = repoMascota;
    }

        public void OnGet() {
            Mascotas = listarMascotas();
        }

        public ActionResult OnPost() {
            if(!ModelState.IsValid) {
                return RedirectToPage("ListaPropietario");
            }
            AddMascota();
            return RedirectToPage("ListaMascota");
        }

        public IEnumerable<Mascota> listarMascotas() {
            IEnumerable<Mascota> Mascotas = _repoMascota.GetAllMascotas();
            return Mascotas;
        }

        private void AddMascota () {

            _repoMascota.AddMascota(new Mascota {
                PropietarioId = Mascota.PropietarioId,
                Nombre = Mascota.Nombre,
                FechaNacimiento = Mascota.FechaNacimiento,
                TipoMascota = Mascota.TipoMascota,
                Raza = Mascota.Raza,
                Sexo = Mascota.Sexo,
                Color = Mascota.Color,
                Afiliado = Mascota.Afiliado
            });
        }

        public IActionResult OnGetDeleteMascota(int Id) {
            _repoMascota.DeleteMascota(Id);
            return Redirect("ListaMascota");
        }
    }
}
