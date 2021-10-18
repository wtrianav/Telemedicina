using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class ListaRegistrosModel : PageModel {

        private readonly IRepositorioMascota _repoMascota;
        [BindProperty]
        public Mascota Mascota { get; set; }

        public IEnumerable<RegistroVisita> Registros { get; set; }

        public ListaRegistrosModel(IRepositorioMascota repoMascota) {
            _repoMascota = repoMascota;  
        }

        public void OnGet(int? mascotaId) {
            if (mascotaId.HasValue) {
                Mascota = _repoMascota.GetMascota(mascotaId.Value);
            }

            if(Mascota == null) {
                Page();
            }
            else {
                Registros = _repoMascota.GetRegistrosMascota(mascotaId.Value);
            }
        }  
    }
}
