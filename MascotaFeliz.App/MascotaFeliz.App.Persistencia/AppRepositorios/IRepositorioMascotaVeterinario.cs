using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

// Un conjunto de firmas de encabezados de los métodos pero no tienen implementación
namespace MascotaFeliz.App.Persistencia {
    public interface IRepositorioMascotaVeterinario {
        MascotaVeterinario AddMascotaVeterinario(MascotaVeterinario mascotaVeterinario);
    }
}