using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

// Un conjunto de firmas de encabezados de los métodos pero no tienen implementación
namespace MascotaFeliz.App.Persistencia {
    public interface IRepositorioPropietario {
        IEnumerable<Propietario> GetAllPropietarios();
        Propietario AddPropietario(Propietario propietario);
        Propietario UpdatePropietario(Propietario propietario);
        bool DeletePropietario(int idPropietario);
        Propietario GetPropietario(int idPropietario);
    }
}