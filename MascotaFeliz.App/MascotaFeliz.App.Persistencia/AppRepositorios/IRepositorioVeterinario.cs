using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

// Un conjunto de firmas de encabezados de los métodos pero no tienen implementación
namespace MascotaFeliz.App.Persistencia {
    public interface IRepositorioVeterinario {
        IEnumerable<Veterinario> GetAllVeterinarios();
        Veterinario AddVeterinario(Veterinario veterinario);
        Veterinario UpdateVeterinario(Veterinario veterinario);
        void DeleteVeterinario(int idVeterinario);
        Veterinario GetVeterinario(int idVeterinario);
    }
}