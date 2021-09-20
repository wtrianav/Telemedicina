using System;

namespace MascotaFeliz.App.Dominio {


	public class Propietario : Persona {
		public int IdPropietario { get; set; }

		public Mascota Mascota { get; set; }

	}

}
