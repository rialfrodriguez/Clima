//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClimaAdmin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Encuestas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Encuestas()
        {
            this.AsignacionesEmpresas = new HashSet<AsignacionesEmpresas>();
            this.EncuestaPreguntas = new HashSet<EncuestaPreguntas>();
        }
    
        public short IdPeriodo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public short Activo { get; set; }
        public int IdEncuesta { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AsignacionesEmpresas> AsignacionesEmpresas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncuestaPreguntas> EncuestaPreguntas { get; set; }
        public virtual Periodos Periodos { get; set; }
    }
}
