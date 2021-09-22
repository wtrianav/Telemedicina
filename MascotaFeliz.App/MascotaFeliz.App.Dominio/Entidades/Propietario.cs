using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MascotaFeliz.App.Dominio {


	public class Propietario {
		public int Id { get; set; }
		public string Cedula { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public string NumeroTelefono { get; set; }
		public string Direccion { get; set; }
		public string Email { get; set; }
		public List<Mascota> Mascotas { get; set; }
	}

}
