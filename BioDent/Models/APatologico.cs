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

    public partial class APatologico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APatologico()
        {
            this.Expediente = new HashSet<Expediente>();
        }
    
        public int Identificador { get; set; }
        [Display(Name = "Enfermedad Grave")]
        public string EnfermedadGrave { get; set; }
        public string Traumatismo { get; set; }
        public string Transfunciones { get; set; }
        public string Hemorragias { get; set; }
        public string Donadores { get; set; }
        public string Alergias { get; set; }
        [Display(Name = "Consume Medicamento")]
        public string ConsumeMedicamento { get; set; }
        [Display(Name = "¿Accidentes con tratamientos médicos?")]
        public string AccidenteTratamiento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Expediente> Expediente { get; set; }
    }
}
