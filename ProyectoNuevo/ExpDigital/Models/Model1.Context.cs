﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExpDigital.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ExpedienteDigitalEntities : DbContext
    {
        public ExpedienteDigitalEntities()
            : base("name=ExpedienteDigitalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Articulo> Articuloes { get; set; }
        public virtual DbSet<Capitulo> Capituloes { get; set; }
        public virtual DbSet<CitaDeAtestado> CitaDeAtestados { get; set; }
        public virtual DbSet<DesarrolloSoftware> DesarrolloSoftwares { get; set; }
        public virtual DbSet<Libro> Libroes { get; set; }
        public virtual DbSet<ObraAdministrativaDesarrollo> ObraAdministrativaDesarrolloes { get; set; }
        public virtual DbSet<ObraArtistica> ObraArtisticas { get; set; }
        public virtual DbSet<ObraDidactica> ObraDidacticas { get; set; }
        public virtual DbSet<OtraObraProfesional> OtraObraProfesionals { get; set; }
        public virtual DbSet<Pai> Pais { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<PersonaXCita> PersonaXCitas { get; set; }
        public virtual DbSet<PersonaXDesarrolloSoftware> PersonaXDesarrolloSoftwares { get; set; }
        public virtual DbSet<PersonaXObraAdministrativaDesarrollo> PersonaXObraAdministrativaDesarrolloes { get; set; }
        public virtual DbSet<PersonaXObraDidactica> PersonaXObraDidacticas { get; set; }
        public virtual DbSet<PersonaXOtraObraProfesional> PersonaXOtraObraProfesionals { get; set; }
        public virtual DbSet<ProyectoGraduacionGalardonado> ProyectoGraduacionGalardonadoes { get; set; }
        public virtual DbSet<TipoObraAdmi> TipoObraAdmis { get; set; }
        public virtual DbSet<TipoObraProfesional> TipoObraProfesionals { get; set; }
    }
}
