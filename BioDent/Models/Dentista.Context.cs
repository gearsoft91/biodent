﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_DentistaEntities : DbContext
    {
        public DB_DentistaEntities()
            : base("name=DB_DentistaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
   
        public virtual DbSet<AHereditario> AHereditario { get; set; }
        public virtual DbSet<ANoPatologico> ANoPatologico { get; set; }
        public virtual DbSet<AOdontologico> AOdontologico { get; set; }
        public virtual DbSet<APatologico> APatologico { get; set; }
        public virtual DbSet<Consulta> Consulta { get; set; }
        public virtual DbSet<Diente> Diente { get; set; }
        public virtual DbSet<EATM> EATM { get; set; }
        public virtual DbSet<EExtraOral> EExtraOral { get; set; }
        public virtual DbSet<EIntraOral> EIntraOral { get; set; }
        public virtual DbSet<Expediente> Expediente { get; set; }
        public virtual DbSet<Grado> Grado { get; set; }
        public virtual DbSet<Medico> Medico { get; set; }
        public virtual DbSet<Odontograma> Odontograma { get; set; }
        public virtual DbSet<Paciente> Paciente { get; set; }
    }
}