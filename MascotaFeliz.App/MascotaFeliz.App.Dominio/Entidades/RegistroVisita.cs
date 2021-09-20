using System;

namespace MascotaFeliz.App.Dominio {


using System;

namespace MascotaFeliz.App.Dominio {

	public class RegistroVisita {
		public int Id { get; set; }
		public string TarjetaProfesionalVeterinario { get; set; }
		public DateTime FechaHora { get; set; }
		public string Temperatura { get; set; }
		public float Peso { get; set; }
		public string FrecuenciaRespiratoria { get; set; }
		public string FrecuenciaCardiaca { get; set; }
		public EstadoAnimo EstadoAnimo { get; set; }
		public string Medicamentos { get; set; }
		public string Recomendaciones { get; set; }
		
		// Relación entre Mascota y RegistroVisita
		public Mascota Mascota { get; set; }

	}

}
