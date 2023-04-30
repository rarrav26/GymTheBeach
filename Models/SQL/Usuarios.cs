//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models.SQL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuarios()
        {
            this.Pagos = new HashSet<Pagos>();
            this.Presentismo = new HashSet<Presentismo>();
        }
    
        public int UserID { get; set; }
        public int MembresiaID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public int GeneroID { get; set; }
        public bool Habilitado { get; set; }
        public Nullable<bool> EsAdmin { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Domicilio { get; set; }
        public string Profesion { get; set; }
        public string Email { get; set; }
        public string ComoNosConocio { get; set; }
        public string Observaciones { get; set; }
        public string Username { get; set; }
        public string Salt { get; set; }
        public string Hash { get; set; }
    
        public virtual Generos Generos { get; set; }
        public virtual Membresias Membresias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pagos> Pagos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Presentismo> Presentismo { get; set; }
    }
}
