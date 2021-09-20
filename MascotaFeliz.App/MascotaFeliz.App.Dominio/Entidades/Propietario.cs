using System;
using System.Collections.Generic;

namespace MascotaFeliz.App.Dominio {


	public class Propietario : Persona {
		public int IdPropietario { get; set; }
		// Relación de un propietario a muchas mascotas
		public List<Mascota> Mascotas { get; set; }
	}

}
