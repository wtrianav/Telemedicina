using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MascotaFeliz.App.Frontend.Pages {
    public class ListaRegistroVisitaModel : PageModel {

    private readonly IRepositorioRegistroVisita _repoRegistroVisita;
    public IEnumerable<RegistroVisita> RegistrosVisitas { get; set;}
    [BindProperty]
    public RegistroVisita RegistroVisita { get; set;} 

    public ListaRegistroVisitaModel (IRepositorioRegistroVisita repoRegistroVisita) {
        _repoRegistroVisita = repoRegistroVisita;
    }

        public void OnGet() {
            RegistrosVisitas = listarRegistrosVisitas();
        }

        public ActionResult OnPost() {
            if(!ModelState.IsValid) {
                return RedirectToPage("ListaPropietario");
            }
            AddRegistroVisita();
            return RedirectToPage("ListaRegistroVisita");
        }

        public IEnumerable<RegistroVisita> listarRegistrosVisitas() {
            IEnumerable<RegistroVisita> RegistrosVisitas = _repoRegistroVisita.GetAllRegistroVisitas();
            return RegistrosVisitas;
        }

        private void AddRegistroVisita () {

            _repoRegistroVisita.AddRegistroVisita(new RegistroVisita {
                MascotaId = RegistroVisita.MascotaId,
                TarjetaProfesionalVeterinario = RegistroVisita.TarjetaProfesionalVeterinario,
                FechaHora = RegistroVisita.FechaHora,
                Temperatura = RegistroVisita.Temperatura,
                Peso = RegistroVisita.Peso,
                FrecuenciaRespiratoria = RegistroVisita.FrecuenciaRespiratoria,
                FrecuenciaCardiaca = RegistroVisita.FrecuenciaCardiaca,
                EstadoAnimo = RegistroVisita.EstadoAnimo,
                Medicamentos = RegistroVisita.Medicamentos,
                Recomendaciones = RegistroVisita.Recomendaciones     
            });
        }

        public IActionResult OnGetDeleteRegistroVisita(int Id) {
            _repoRegistroVisita.DeleteRegistroVisita(Id);
            return Redirect("ListaRegistroVisita");
        }
    
    }
}
