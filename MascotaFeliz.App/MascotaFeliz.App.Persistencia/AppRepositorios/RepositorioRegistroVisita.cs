using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia {

    public class RepositorioRegistroVisita : IRepositorioRegistroVisita {

        /// <summary>
        /// Referencia al contexto de Paciente
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// El Método constructor utiliza inyección de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"><param>//

        public RepositorioRegistroVisita (AppContext appContext) {
            _appContext = appContext;
        }

        RegistroVisita IRepositorioRegistroVisita.AddRegistroVisita(RegistroVisita registroVisita) {
            var registroVisitaAdicionada = _appContext.RegistrosVisitas.Add(registroVisita);
            _appContext.SaveChanges();
            return registroVisitaAdicionada.Entity;
        }
        
        void IRepositorioRegistroVisita.DeleteRegistroVisita (int idRegistroVisita) {
            var registroVisitaEncontrada = _appContext.RegistrosVisitas.FirstOrDefault(r => r.Id == idRegistroVisita);
            if (registroVisitaEncontrada == null)
                return;
            _appContext.RegistrosVisitas.Remove(registroVisitaEncontrada);
            _appContext.SaveChanges();
        }

        IEnumerable<RegistroVisita> IRepositorioRegistroVisita.GetAllRegistroVisitas() {
            return _appContext.RegistrosVisitas;
        }

        RegistroVisita IRepositorioRegistroVisita.GetRegistroVisita (int idRegistroVisita) {
            return _appContext.RegistrosVisitas.FirstOrDefault(r => r.Id == idRegistroVisita);
        }

        RegistroVisita IRepositorioRegistroVisita.UpdateRegistroVisita (RegistroVisita registroVisita) {
            var registroVisitaEncontrada = _appContext.RegistrosVisitas.FirstOrDefault(r => r.Id == registroVisita.Id);
            if (registroVisitaEncontrada != null) {
                registroVisitaEncontrada.MascotaId = registroVisita.MascotaId;
                registroVisitaEncontrada.TarjetaProfesionalVeterinario = registroVisita.TarjetaProfesionalVeterinario;
                registroVisitaEncontrada.FechaHora = registroVisita.FechaHora;
                registroVisitaEncontrada.Temperatura = registroVisita.Temperatura;
                registroVisitaEncontrada.Peso = registroVisita.Peso;
                registroVisitaEncontrada.FrecuenciaRespiratoria = registroVisita.FrecuenciaRespiratoria;
                registroVisitaEncontrada.FrecuenciaCardiaca = registroVisita.FrecuenciaCardiaca;
                registroVisitaEncontrada.EstadoAnimo = registroVisita.EstadoAnimo;
                registroVisitaEncontrada.Medicamentos = registroVisita.Medicamentos;
                registroVisitaEncontrada.Recomendaciones = registroVisita.Recomendaciones;

                _appContext.SaveChanges();
            }

            return registroVisitaEncontrada;
        }
    }
}