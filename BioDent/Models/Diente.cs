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

    public partial class Diente
    {
        public int Identificador { get; set; }
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }
    
        public virtual Odontograma Odontograma { get; set; }
    }
}
