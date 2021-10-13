using System;
using System.ComponentModel.DataAnnotations;

namespace MascotaFeliz.App.Dominio {

    public class RegistroVisita {
		public int Id { get; set; }
		[Required(ErrorMessage = "Este campo es obligatorio.")]
		[RegularExpression("[0-9]*", ErrorMessage = "Solo se permiten números")]
		public int MascotaId { get; set; }
		[Required(ErrorMessage = "Este campo es obligatorio.")]
		[MaxLength(8, ErrorMessage = "Escriba un máximo de {1} caracteres.")]
		[MinLength(5, ErrorMessage = "Escriba un mínimo de {1} caracteres.")]
		[RegularExpression("[0-9]*", ErrorMessage = "Solo se permiten números")]
		public string TarjetaProfesionalVeterinario { get; set; }
		[Required(ErrorMessage = "Este campo es obligatorio.")]
        [DataType(DataType.Date)]
		public DateTime FechaHora { get; set; }
		[Required(ErrorMessage = "Este campo es obligatorio.")]
		[MaxLength(2, ErrorMessage = "Escriba un máximo de {1} caracteres.")]
		[MinLength(2, ErrorMessage = "Escriba un mínimo de {1} caracteres.")]
		[Range(35, 40)]
		[RegularExpression("[0-9]*", ErrorMessage = "Solo se permiten números")]
		public string Temperatura { get; set; }
		[Required(ErrorMessage = "Este campo es obligatorio.")]
		[MaxLength(3, ErrorMessage = "Escriba un máximo de {1} caracteres.")]
		[MinLength(1, ErrorMessage = "Escriba un mínimo de {1} caracteres.")]
		[RegularExpression("[0-9]*", ErrorMessage = "Solo se permiten números")]
		public float Peso { get; set; }
		[Required(ErrorMessage = "Este campo es obligatorio.")]
		[MaxLength(7, ErrorMessage = "Escriba un máximo de {1} caracteres.")]
		[MinLength(2, ErrorMessage = "Escriba un mínimo de {1} caracteres.")]
		public string FrecuenciaRespiratoria { get; set; }
		[Required(ErrorMessage = "Este campo es obligatorio.")]
		[MaxLength(9, ErrorMessage = "Escriba un máximo de {1} caracteres.")]
		[MinLength(2, ErrorMessage = "Escriba un mínimo de {1} caracteres.")]
		public string FrecuenciaCardiaca { get; set; }
		[Required(ErrorMessage = "Este campo es obligatorio.")]
		public EstadoAnimo EstadoAnimo { get; set; }
		[Required(ErrorMessage = "Este campo es obligatorio.")]
		public string Medicamentos { get; set; }
		[Required(ErrorMessage = "Este campo es obligatorio.")]
		public string Recomendaciones { get; set; }
	}

}
