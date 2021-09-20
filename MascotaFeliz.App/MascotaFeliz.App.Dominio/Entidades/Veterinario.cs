using System;

namespace MascotaFeliz.App.Dominio {

	public class Veterinario : Persona{
		public string Especialidad { get; set; }
		public string TarjetaProfesional { get; set; }
		public Mascota Mascota { get; set }
		
	}
}