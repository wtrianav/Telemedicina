using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia {

    public class RepositorioMascota : IRepositorioMascota {

        /// <summary>
        /// Referencia al contexto de Paciente
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// El Método constructor utiliza inyección de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"><param>//

        public RepositorioMascota (AppContext appContext) {
            _appContext = appContext;
        }

        Mascota IRepositorioMascota.AddMascota(Mascota mascota) {
            var mascotaAdicionada = _appContext.Mascotas.Add(mascota);
            _appContext.SaveChanges();
            return mascotaAdicionada.Entity;
        }

        void IRepositorioMascota.DeleteMascota (int idMascota) {
            var mascotaEncontrada = _appContext.Mascotas.FirstOrDefault(m => m.Id == idMascota);
            if (mascotaEncontrada == null)
                return;
            _appContext.Mascotas.Remove(mascotaEncontrada);
            _appContext.SaveChanges();
        }

        IEnumerable<Mascota> IRepositorioMascota.GetAllMascotas() {
            return _appContext.Mascotas;
        }

        Mascota IRepositorioMascota.GetMascota (int idMascota) {
            return _appContext.Mascotas.FirstOrDefault(m => m.Id == idMascota);
        }

        Mascota IRepositorioMascota.UpdateMascota (Mascota mascota) {
            var mascotaEncontrada = _appContext.Mascotas.FirstOrDefault(m => m.Id == mascota.Id);
            if (mascotaEncontrada != null) {
                mascotaEncontrada.PropietarioId = mascota.PropietarioId;
                mascotaEncontrada.Nombre = mascota.Nombre;
                mascotaEncontrada.FechaNacimiento = mascota.FechaNacimiento;
                mascotaEncontrada.TipoMascota = mascota.TipoMascota;
                mascotaEncontrada.Raza = mascota.Raza;
                mascotaEncontrada.Sexo = mascota.Sexo;
                mascotaEncontrada.Color = mascota.Color;
                mascotaEncontrada.Afiliado = mascota.Afiliado;

                _appContext.SaveChanges();
            }

            return mascotaEncontrada;
        }

        IEnumerable<RegistroVisita> IRepositorioMascota.GetRegistrosMascota(int idMascota)
        {
            var mascota = _appContext.Mascotas.Where(s => s.Id==idMascota)
                                               .Include(s=>s.Visitas)
                                               .FirstOrDefault();

            return mascota.Visitas;
        }
    }
}