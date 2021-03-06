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

    public partial class ANoPatologico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ANoPatologico()
        {
            this.Expediente = new HashSet<Expediente>();
        }
    
        public int Identificador { get; set; }
        public Nullable<int> Higiene { get; set; }
        [Display(Name = "Alimentación")]
        public Nullable<int> Alimentacion { get; set; }
        [Display(Name = "Cepillado al Día")]
        public Nullable<int> VecesCepillado { get; set; }
        [Display(Name = "Número de Personas en Casa")]
        public Nullable<int> PersonasEnCasa { get; set; }
        [Display(Name = "Practica Deporte")]
        public string PracticaDeporte { get; set; }
        [Display(Name = "Consume Alcohol")]
        public string ConsumeAlcohol { get; set; }
        public string Embarazada { get; set; }
        public Nullable<int> Grado { get; set; }
    
        public virtual Grado Grado1 { get; set; }
        public virtual Grado Grado2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Expediente> Expediente { get; set; }
    }
}
