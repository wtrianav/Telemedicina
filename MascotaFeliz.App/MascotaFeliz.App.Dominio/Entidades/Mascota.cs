using System;
using System.Collections.Generic;

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

        public List<MascotaVeterinario> MascotaVeterinario;
        public List<Veterinario> Veterinarios;
        public List<RegistroVisita> Visitas;
    }
}
