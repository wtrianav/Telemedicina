using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

// Un conjunto de firmas de encabezados de los métodos pero no tienen implementación
namespace MascotaFeliz.App.Persistencia {
    public interface IRepositorioMascota {
        IEnumerable<Mascota> GetAllMascotas();
        Mascota AddMascota(Mascota mascota);
        Mascota UpdateMascota(Mascota mascota);
        void DeleteMascota(int idMascota);
        Mascota GetMascota(int idMascota);
        IEnumerable<RegistroVisita> GetRegistrosMascota(int idMascota);
    }
}