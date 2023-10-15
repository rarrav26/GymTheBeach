using Models.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UsuarioDto
    {
        public UsuarioDto(Usuarios usuario)
        {
            if (usuario == null)
                return;

            Nombre = usuario.Nombre;
            Apellido = usuario.Apellido;
            DNI = usuario.DNI;
            Genero = usuario.Generos.Descripcion;
            FechaNacimiento = usuario.FechaNacimiento;
            Telefono = usuario.Telefono;
            Domicilio = usuario.Domicilio;
            Profesion = usuario.Profesion;
            Email = usuario.Email;
            ComoNosConocio = usuario.ComoNosConocio;
            Observaciones = usuario.Observaciones;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Genero { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Domicilio { get; set; }
        public string Profesion { get; set; }
        public string Email { get; set; }
        public string ComoNosConocio { get; set; }
        public string Observaciones { get; set; }
    }
}
