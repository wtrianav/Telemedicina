using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Frontend.Pages {
    public class EditarPropietarioModel : PageModel {

        private readonly IRepositorioPropietario _repoPropietario;
        //private static IRepositorioPropietario _repoPropietario = new RepositorioPropietario(new Persistencia.AppContext());
        //public IEnumerable<Propietario> Propietarios { get; set;}
        [BindProperty]
        public Propietario Propietario { get; set;} 

        public EditarPropietarioModel (IRepositorioPropietario repoPropietario) {
            this._repoPropietario = repoPropietario;
        }
        
        //public void OnGet(int idPropietario) {
        public IActionResult OnGet(int id) {
            Propietario = _repoPropietario.GetPropietario(id);
                // Console.WriteLine(id);
                return Page();
        }

        public IActionResult OnPost() {
            Propietario = _repoPropietario.UpdatePropietario(Propietario);
            return Page();
        }
    }        
}
