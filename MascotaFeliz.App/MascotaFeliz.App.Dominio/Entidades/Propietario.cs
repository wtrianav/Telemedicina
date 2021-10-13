using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MascotaFeliz.App.Dominio
{

    public class Propietario {
		
		public int Id { get; set; }
		[Required(ErrorMessage = "Este campo es obligatorio.")]
		[MaxLength(10, ErrorMessage = "No puede superar los {1} caracteres.")]
		[MinLength(7, ErrorMessage = "Debe tener como mínimo {1} caracteres.")]
		[RegularExpression("[0-9]*", ErrorMessage = "Solo se permiten números")]
		public string Cedula { get; set; }
		[Required(ErrorMessage = "Este campo es obligatorio.")]
		[MaxLength(25, ErrorMessage = "Escriba un máximo de {1} caracteres.")]
		[MinLength(3, ErrorMessage = "Escriba un mínimo de {1} caracteres.")]
		[RegularExpression("[A-Z a-z]*", ErrorMessage = "Solo se permiten letras")]
		public string Nombre { get; set; }
		[Required(ErrorMessage = "Este campo es obligatorio.")]
		[MaxLength(25, ErrorMessage = "Escriba un máximo de {1} caracteres.")]
		[MinLength(3, ErrorMessage = "Escriba un mínimo de {1} caracteres.")]
		[RegularExpression("[A-Z a-z]*", ErrorMessage = "Solo se permiten letras")]
		public string Apellido { get; set; }
		[Required(ErrorMessage = "Este campo es obligatorio.")]
		[MaxLength(10, ErrorMessage = "Escriba un máximo de {1} caracteres.")]
		[MinLength(7, ErrorMessage = "Escriba un mínimo de {1} caracteres.")]
		[RegularExpression("[0-9]*", ErrorMessage = "Solo se permiten números")]
		public string NumeroTelefono { get; set; }
		[Required(ErrorMessage = "Este campo es obligatorio.")]
		[MaxLength(100, ErrorMessage = "Escriba un máximo de {1} caracteres.")]
		[MinLength(15, ErrorMessage = "Escriba un mínimo de {1} caracteres.")]
		public string Direccion { get; set; }
		[Required(ErrorMessage = "Este campo es obligatorio.")]
		[EmailAddress(ErrorMessage = "Ingrese una dirección Email válida.")]
		public string Email { get; set; }
		public List<Mascota> Mascotas { get; set; }
    }

}
