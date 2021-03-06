//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BioDent.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class AHereditario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AHereditario()
        {
            this.Expediente = new HashSet<Expediente>();
        }
    
        public int Identificador { get; set; }
        [Display(Name = "Alguna persona de su familia a fallecido por:")]
        public string FamiliarFallecidoDeEnfermedad { get; set; }
        public string Causa { get; set; }
        [Display(Name = "¿Algún miembro de su familia está enfermo en este momento?")]
        public string FamiliarEnfermo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Expediente> Expediente { get; set; }
    }
}
