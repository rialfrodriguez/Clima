//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clima.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SeleccionMultiples
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SeleccionMultiples()
        {
            this.EncuestaPreguntas = new HashSet<EncuestaPreguntas>();
            this.OpcionesSeleccionMultiple = new HashSet<OpcionesSeleccionMultiple>();
        }
    
        public int IdSeleccionMultiple { get; set; }
        public string Enunciado { get; set; }
        public int IdDimension { get; set; }
        public Nullable<short> IsMultiple { get; set; }
    
        public virtual Dimensiones Dimensiones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncuestaPreguntas> EncuestaPreguntas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpcionesSeleccionMultiple> OpcionesSeleccionMultiple { get; set; }
    }
}
