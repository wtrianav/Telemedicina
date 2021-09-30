using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola {
    class Program {
        private static IRepositorioPropietario _repoPropietario = new RepositorioPropietario(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioRegistroVisita _repoRegistroVisita = new RepositorioRegistroVisita(new Persistencia.AppContext());
        private static IRepositorioMascotaVeterinario _repoMascotaVeterinario = new RepositorioMascotaVeterinario(new Persistencia.AppContext());
        

        static void Main(string[] args) {
            Console.WriteLine("Hello World Entity Framework!");

            //AddVeterinario();
            //AddPropietario();
            //AddMascota();
            //AddMascotaVeterinario();
            BuscarPropietario(1);
            //BuscarMascota(1);
            
            // Propietario Propietario = _repoPropietario.GetPropietario(1);
            // if(Propietario != null) {
            //     Console.WriteLine("El propietario " + Propietario.Nombre + " fue encontrado");
            // }
            // else {
            //     Console.WriteLine("No encontró a nadie");
            // }

        }

        // Pruebas Propietario
        private static void AddPropietario () {

            var propietario = new Propietario {
                Cedula = "1123863345",
                Nombre = "Alba Julieth",
                Apellido = "Saavedra Arevalo",
                NumeroTelefono = "3120302123",
                Direccion = "Carrera 25 # 22-30",
                Email = "ajulieth@outlook.com"
            };

            _repoPropietario.AddPropietario(propietario);
            Console.WriteLine("El propietario " + propietario.Nombre + " " + propietario.Apellido + " fue creado exitosamente!!!");
        }

        private static void BuscarPropietario (int idPropietario) {

            var propietario = _repoPropietario.GetPropietario(idPropietario);
            Console.WriteLine("El propietario " + propietario.Nombre + " " +propietario.Apellido + " fue encontrado");

        }

        // Pruebas Mascota
        private static void AddMascota () {

            var mascota = new Mascota {
                PropietarioId = 10,
                Nombre = "Rocky",
                FechaNacimiento = new DateTime(2017, 10, 12),
                TipoMascota = TipoMascota.Canino,
                Raza = "Pitbull",
                Sexo = "Macho",
                Color = "Negro",
                Afiliado = true
            };

            _repoMascota.AddMascota(mascota);
            Console.WriteLine("La mascota " + mascota.Nombre + " fue creada exitosamente!!!");
        }

        private static void BuscarMascota (int idMascota) {

            var mascota = _repoMascota.GetMascota(idMascota);
            Console.WriteLine("Mascota: " + mascota.Nombre + " encontrada");

        }

        // Pruebas Veterinario
        private static void AddVeterinario () {

            var veterinario = new Veterinario {
                Nombre = "David Leonardo",
                Apellido = "Mayorga Restrepo",
                TarjetaProfesionalVeterinario = "3267854",
                NumeroTelefono = "320315321",
                Email = "dmayorga@gmail.com"
            };

            _repoVeterinario.AddVeterinario(veterinario);
            Console.WriteLine("El veterinario " + veterinario.Nombre + " " + veterinario.Apellido + " fue creado exitosamente!!!");
        }

        // Pruebas MascotaVeterinario 
            private static void AddMascotaVeterinario () {

            var mascotaVeterinario = new MascotaVeterinario {
                MascotaId = 1,
                VeterinarioId = 2
            };

            _repoMascotaVeterinario.AddMascotaVeterinario(mascotaVeterinario);
            Console.WriteLine("La creación fue exitosa!!!");
        }   
    }
}
