using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia {

    public class RepositorioVeterinario : IRepositorioVeterinario {

        /// <summary>
        /// Referencia al contexto de Paciente
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// El Método constructor utiliza inyección de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"><param>//

        public RepositorioVeterinario (AppContext appContext) {
            _appContext = appContext;
        }

        Veterinario IRepositorioVeterinario.AddVeterinario(Veterinario veterinario) {
            var veterinarioAdicionado = _appContext.Veterinarios.Add(veterinario);
            _appContext.SaveChanges();
            return veterinarioAdicionado.Entity;
        }

        void IRepositorioVeterinario.DeleteVeterinario (int idVeterinario) {
            var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v => v.Id == idVeterinario);
            if (veterinarioEncontrado == null)
                return;
            _appContext.Veterinarios.Remove(veterinarioEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Veterinario> IRepositorioVeterinario.GetAllVeterinarios() {
            return _appContext.Veterinarios;
        }

        Veterinario IRepositorioVeterinario.GetVeterinario (int idVeterinario) {
            return _appContext.Veterinarios.FirstOrDefault(v => v.Id == idVeterinario);
        }

        Veterinario IRepositorioVeterinario.UpdateVeterinario (Veterinario veterinario) {
            var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v => v.Id == veterinario.Id);
            if (veterinarioEncontrado != null) {
                veterinarioEncontrado.Nombre = veterinario.Nombre;
                veterinarioEncontrado.Apellido = veterinario.Apellido;
                veterinarioEncontrado.TarjetaProfesionalVeterinario = veterinario.TarjetaProfesionalVeterinario;
                veterinarioEncontrado.NumeroTelefono = veterinario.NumeroTelefono;
                veterinarioEncontrado.Email = veterinario.Email;
                
                _appContext.SaveChanges();
            }

            return veterinarioEncontrado;
        }
    }
}