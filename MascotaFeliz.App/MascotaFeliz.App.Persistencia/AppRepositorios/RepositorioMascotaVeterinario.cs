using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia {

    public class RepositorioMascotaVeterinario : IRepositorioMascotaVeterinario {

        /// <summary>
        /// Referencia al contexto de Paciente
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// El Método constructor utiliza inyección de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"><param>//

        public RepositorioMascotaVeterinario (AppContext appContext) {
            _appContext = appContext;
        }

        MascotaVeterinario IRepositorioMascotaVeterinario.AddMascotaVeterinario(MascotaVeterinario mascotaVeterinario) {
            var mascotaVeterinarioAdicionada = _appContext.MascotasVeterinarios.Add(mascotaVeterinario);
            _appContext.SaveChanges();
            return mascotaVeterinarioAdicionada.Entity;
        }

    }
}