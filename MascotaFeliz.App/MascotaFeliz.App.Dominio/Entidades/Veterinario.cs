using System;
using System.Collections.Generic;

namespace MascotaFeliz.App.Dominio {

	public class Veterinario : Persona{
		public string Especialidad { get; set; }
		public string TarjetaProfesional { get; set; }
		public Mascota Mascota { get; set; }
		// Relación de un veterinario a muchos registros
		public List<RegistroVisita> RegistroVisitas { get; set; }
	}
}