using System.Collections.Generic;
using MascotaFeliz.App.Dominio;

// Un conjunto de firmas de encabezados de los métodos pero no tienen implementación
namespace MascotaFeliz.App.Persistencia {
    public interface IRepositorioRegistroVisita {
        IEnumerable<RegistroVisita> GetAllRegistroVisitas();
        RegistroVisita AddRegistroVisita(RegistroVisita registroVisita);
        RegistroVisita UpdateRegistroVisita(RegistroVisita registroVisita);
        void DeleteRegistroVisita(int idRegistroVisita);
        RegistroVisita GetRegistroVisita(int idRegistroVisita);
    }
}