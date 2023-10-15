using Models.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.SQL
{
    public partial class Usuarios
    {
        public dynamic ToDataTransferObject()
        {
            //return new UsuarioDto(this);
            return new
            {
                Nombre = this.Nombre,
                Apellido = this.Apellido,
                DNI = this.DNI,
                Genero = this.Generos.Descripcion,
                FechaNacimiento = this.FechaNacimiento,
                Telefono = this.Telefono,
                Domicilio = this.Domicilio,
                Profesion = this.Profesion,
                Email = this.Email,
                ComoNosConocio = this.ComoNosConocio,
                Observaciones = this.Observaciones
            };
        }
    }
}
