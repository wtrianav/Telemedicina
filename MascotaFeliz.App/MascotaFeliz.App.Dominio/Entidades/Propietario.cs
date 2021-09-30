using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MascotaFeliz.App.Dominio {

    public class Propietario {
		public int Id { get; set; }
		// [Required, StringLength(10)]
		// [MaxLength(10, ErrorMessage = "Escriba un máximo de 10 caracteres.")]
		// [MinLength(7, ErrorMessage = "Escriba un mínimo de 7 caracteres.")]
		public string Cedula { get; set; }
		// [Required(ErrorMessage = "Escriba el nombre del propietario.")]
		// [MaxLength(25, ErrorMessage = "Escriba un máximo de 25 caracteres.")]
		// [MinLength(3, ErrorMessage = "Escriba un mínimo de 3 caracteres.")]
		public string Nombre { get; set; }
		// [Required(ErrorMessage = "Escriba el apellido del propietario.")]
		// [MaxLength(25, ErrorMessage = "Escriba un máximo de 25 caracteres.")]
		// [MinLength(3, ErrorMessage = "Escriba un mínimo de 3 caracteres.")]
		public string Apellido { get; set; }
		// [Required(ErrorMessage = "Escriba el número de teléfono del propietario.")]
		// [MaxLength(10, ErrorMessage = "Escriba un máximo de 10 caracteres.")]
		// [MinLength(7, ErrorMessage = "Escriba un mínimo de 7 caracteres.")]
		public string NumeroTelefono { get; set; }
		// [Required(ErrorMessage = "Escriba la dirección del propietario.")]
		// [MaxLength(100, ErrorMessage = "Escriba un máximo de 100 caracteres.")]
		// [MinLength(20, ErrorMessage = "Escriba un mínimo de 20 caracteres.")]
		public string Direccion { get; set; }
		// [Display(Name = "correo electrónico")]
		// [Required]
		// [EmailAddress]
		public string Email { get; set; }
		public List<Mascota> Mascotas { get; set; }
    }

}
