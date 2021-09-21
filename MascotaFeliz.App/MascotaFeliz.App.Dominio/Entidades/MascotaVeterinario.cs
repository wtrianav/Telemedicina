using System;

namespace MascotaFeliz.App.Dominio
{
    public class MascotaVeterinario {
        public int MascotaId { get; set; }
        public int VeterinarioId { get; set; }
        public Veterinario veterinario { get; set; }
        public Mascota mascota { get; set; }
    }
}