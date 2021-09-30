
namespace MascotaFeliz.App.Dominio
{
    public class MascotaVeterinario {
        public int MascotaId { get; set; }
        public int VeterinarioId { get; set; }
        public Veterinario Veterinario { get; set; }
        public Mascota Mascota { get; set; }
    }
}