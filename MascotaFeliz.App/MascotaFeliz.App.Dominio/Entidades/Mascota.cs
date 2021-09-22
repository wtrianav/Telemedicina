using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MascotaFeliz.App.Dominio {
    
	public class Mascota {
        
		public int Id { get; set; }
        public int PropietarioId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public TipoMascota TipoMascota { get; set; }
        public string Raza { get; set; }
        public string Sexo { get; set;}
        public string Color { get; set;}
        public bool Afiliado { get; set; }
        public List<MascotaVeterinario> MascotaVeterinario { get; set; }
        public List<RegistroVisita> Visitas { get; set; }
    }
}
