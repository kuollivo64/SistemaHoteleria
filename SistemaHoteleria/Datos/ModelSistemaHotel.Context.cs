﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaHoteleria.Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SistemaHotelWaraEntitiesV1 : DbContext
    {
        public SistemaHotelWaraEntitiesV1()
            : base("name=SistemaHotelWaraEntitiesV1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DetalleHabitacion> DetalleHabitacion { get; set; }
        public virtual DbSet<DetalleRegistroLimpiezas> DetalleRegistroLimpiezas { get; set; }
        public virtual DbSet<DetalleRegistroMantenimiento> DetalleRegistroMantenimiento { get; set; }
        public virtual DbSet<DetalleReservas> DetalleReservas { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<Gerente> Gerente { get; set; }
        public virtual DbSet<Habitaciones> Habitaciones { get; set; }
        public virtual DbSet<Huespedes> Huespedes { get; set; }
        public virtual DbSet<Limpieza> Limpieza { get; set; }
        public virtual DbSet<Mantenimiento> Mantenimiento { get; set; }
        public virtual DbSet<Recepcionista> Recepcionista { get; set; }
        public virtual DbSet<RegistroHuespedes> RegistroHuespedes { get; set; }
        public virtual DbSet<RegistroLimpieza> RegistroLimpieza { get; set; }
        public virtual DbSet<RegistroMantenimiento> RegistroMantenimiento { get; set; }
        public virtual DbSet<Reservas> Reservas { get; set; }
        public virtual DbSet<Servicios> Servicios { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tipo> Tipo { get; set; }
    
        public virtual ObjectResult<exo_SieteDiasPL_Result> exo_SieteDiasPL()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<exo_SieteDiasPL_Result>("exo_SieteDiasPL");
        }
    
        public virtual ObjectResult<exo_UnMesPL_Result> exo_UnMesPL()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<exo_UnMesPL_Result>("exo_UnMesPL");
        }
    
        public virtual ObjectResult<exo_SieteDiasPL1_Result> exo_SieteDiasPL1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<exo_SieteDiasPL1_Result>("exo_SieteDiasPL1");
        }
    
        public virtual ObjectResult<exo_UnMesPL1_Result> exo_UnMesPL1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<exo_UnMesPL1_Result>("exo_UnMesPL1");
        }
    
        public virtual ObjectResult<exo_SieteDiasPL2_Result> exo_SieteDiasPL2()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<exo_SieteDiasPL2_Result>("exo_SieteDiasPL2");
        }
    
        public virtual ObjectResult<exo_UnMesPL2_Result> exo_UnMesPL2()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<exo_UnMesPL2_Result>("exo_UnMesPL2");
        }
    
        public virtual ObjectResult<exo_DiezDatos2_Result> exo_DiezDatos2()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<exo_DiezDatos2_Result>("exo_DiezDatos2");
        }
    }
}
