using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia {

    public class RepositorioPropietario : IRepositorioPropietario {

        /// <summary>
        /// Referencia al contexto de Paciente
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// El Método constructor utiliza inyección de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"><param>//

        public RepositorioPropietario (AppContext appContext) {
            _appContext = appContext;
        }

        Propietario IRepositorioPropietario.AddPropietario(Propietario propietario) {
            var propietarioAdicionado = _appContext.Propietarios.Add(propietario);
            _appContext.SaveChanges();
            return propietarioAdicionado.Entity;
        }

        bool IRepositorioPropietario.DeletePropietario (int idPropietario) {
            bool deleted = false;
            //Se busca el propietario que se va a eliminar
            var propietario = _appContext.Propietarios.Find(idPropietario);

            if (propietario != null) {
                try {
                    _appContext.Propietarios.Remove(propietario);
                    _appContext.SaveChanges();
                    deleted = true;
                }
                catch (System.Exception) { 
                    deleted = false;
                }
            }
            return deleted;
        }  
             
        IEnumerable<Propietario> IRepositorioPropietario.GetAllPropietarios() {
            return _appContext.Propietarios;
        }

        Propietario IRepositorioPropietario.GetPropietario(int idPropietario) {
            return _appContext.Propietarios.FirstOrDefault(p => p.Id == idPropietario);
        }

        Propietario IRepositorioPropietario.UpdatePropietario (Propietario propietario) {
            var propietarioEncontrado = _appContext.Propietarios.FirstOrDefault(p => p.Id == propietario.Id);
            if (propietarioEncontrado != null) {
                propietarioEncontrado.Cedula = propietario.Cedula;
                propietarioEncontrado.Nombre = propietario.Nombre;
                propietarioEncontrado.Apellido = propietario.Apellido;
                propietarioEncontrado.NumeroTelefono = propietario.NumeroTelefono;
                propietarioEncontrado.Direccion = propietario.Direccion;
                propietarioEncontrado.Email = propietario.Email;
                
                _appContext.SaveChanges();
            }

            return propietarioEncontrado;
        }
    }
}