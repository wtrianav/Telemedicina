using System.Collections.Generic;

namespace MascotaFeliz.App.Dominio {

    public class Veterinario {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TarjetaProfesionalVeterinario { get; set; }
        public string NumeroTelefono { get; set; }
        public string Email { get; set; }
        public List<MascotaVeterinario> MascotaVeterinario { get; set; }
    }
}