using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola {
    class Program {
        private static IRepositorioPropietario _repoPropietario = new RepositorioPropietario(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());

        static void Main(string[] args) {
            Console.WriteLine("Hello World Entity Framework!");

            //AddMascota();
            BuscarMascota(1);
            //AddPropietario();
            //BuscarPropietario(1);

        }

        private static void AddPropietario () {

            var propietario = new Propietario {
                Cedula = "1054544932",
                Nombre = "Ricardo Andrés",
                Apellido = "López Díaz",
                NumeroTelefono = "3206322320",
                Direccion = "Calle 50 # 13-20",
                Email = "ricardolopez@gmail.com"
            };

            _repoPropietario.AddPropietario(propietario);
        }

        private static void BuscarPropietario (int idPropietario) {

            var propietario = _repoPropietario.GetPropietario(idPropietario);
            Console.WriteLine("Propietario: " + propietario.Nombre + propietario.Apellido + " encontrado");

        }

        private static void AddMascota () {

            var mascota = new Mascota {
                PropietarioId = 1,
                Nombre = "Bola de Nieve",
                FechaNacimiento = new DateTime(2019, 04, 12),
                TipoMascota = TipoMascota.Canino,
                Raza = "Labrador",
                Sexo = "Hembra",
                Color = "Golden",
                Afiliado = true
            };

            _repoMascota.AddMascota(mascota);
        }

        private static void BuscarMascota (int idMascota) {

            var mascota = _repoMascota.GetMascota(idMascota);
            Console.WriteLine("Mascota: " + mascota.Nombre + " encontrada");

        }
    }
}
