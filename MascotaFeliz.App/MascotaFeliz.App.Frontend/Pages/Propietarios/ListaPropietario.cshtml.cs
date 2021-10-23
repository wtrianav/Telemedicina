using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using Microsoft.AspNetCore.Authorization;

namespace MascotaFeliz.App.Frontend.Pages {

    [Authorize]
    public class ListaPropietarioModel : PageModel {
    
    private readonly IRepositorioPropietario _repoPropietario;
    public IEnumerable<Propietario> Propietarios { get; set;}
    [BindProperty]
    public Propietario Propietario { get; set;} 

    public ListaPropietarioModel (IRepositorioPropietario repoPropietario) {
        _repoPropietario = repoPropietario;
    }

        public void OnGet() {
            Propietarios = listarPropietarios();
        }

        public ActionResult OnPost() {
            if(!ModelState.IsValid) {
                return RedirectToPage("ListaPropietario");
            }
            AddPropietario();
            return RedirectToPage("ListaPropietario");
        }

        public IEnumerable<Propietario> listarPropietarios() {
            IEnumerable<Propietario> Propietarios = _repoPropietario.GetAllPropietarios();
            return Propietarios;
        }

        private void AddPropietario () {

            _repoPropietario.AddPropietario(new Propietario {
                Cedula = Propietario.Cedula,
                Nombre = Propietario.Nombre,
                Apellido = Propietario.Apellido,
                NumeroTelefono = Propietario.NumeroTelefono,
                Direccion = Propietario.Direccion,
                Email = Propietario.Email
            });
        }

        public IActionResult OnGetDeletePropietario(int Id) {
            _repoPropietario.DeletePropietario(Id);
            return Redirect("ListaPropietario");
        }
    }
}
