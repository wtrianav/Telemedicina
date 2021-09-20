using System;

namespace MascotaFeliz.App.Dominio {
    
	public class Mascota {
        
		public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public TipoMascota TipoMascota { get; set; }
        public string Raza { get; set; }
        public string Sexo { get; set;}
        public string Color { get; set;}
        public bool Afiliado { get; set; }
		// Relación entre Mascota y el registro de la visita
        public RegistroVisita RegistroVisita { get; set; }
		// Relación entre Mascota y el Propietario
        public Propietario Propietario { get; set; }
		// Relación entre Mascota y el Veterinario
        public Veterinario Veterinario { get; set; }

    }
}
