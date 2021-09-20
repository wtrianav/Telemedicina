using System;

namespace MascotaFeliz.App.Dominio {


	public class Propietario : Persona {
		public int Id { get; set; }

		public Mascota Mascota { get; set }

	}

}
