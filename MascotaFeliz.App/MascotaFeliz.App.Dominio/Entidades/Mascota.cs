using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MascotaFeliz.App.Dominio {

    public class Mascota {
        
		public int Id { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio.")]
		[RegularExpression("[0-9]*", ErrorMessage = "Solo se permiten números")]
        public int PropietarioId { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio.")]
		[MaxLength(25, ErrorMessage = "Escriba un máximo de {1} caracteres.")]
		[MinLength(3, ErrorMessage = "Escriba un mínimo de {1} caracteres.")]
		[RegularExpression("[A-Za-z ñÑ ÁáÉéÍíÓóÚú]*", ErrorMessage = "Solo se permiten letras")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public TipoMascota TipoMascota { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio.")]
		[MaxLength(25, ErrorMessage = "Escriba un máximo de {1} caracteres.")]
		[MinLength(3, ErrorMessage = "Escriba un mínimo de {1} caracteres.")]
		[RegularExpression("[A-Za-z ñÑ ÁáÉéÍíÓóÚú]*", ErrorMessage = "Solo se permiten letras")]
        public string Raza { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public string Sexo { get; set;}
        [Required(ErrorMessage = "Este campo es obligatorio.")]
		[MaxLength(25, ErrorMessage = "Escriba un máximo de {1} caracteres.")]
		[MinLength(3, ErrorMessage = "Escriba un mínimo de {1} caracteres.")]
		[RegularExpression("[A-Za-z ñÑ ÁáÉéÍíÓóÚú]*", ErrorMessage = "Solo se permiten letras")]
        public string Color { get; set;}
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public bool Afiliado { get; set; }
        public List<MascotaVeterinario> MascotaVeterinario { get; set; }
        public List<RegistroVisita> Visitas { get; set; }
    }
}
