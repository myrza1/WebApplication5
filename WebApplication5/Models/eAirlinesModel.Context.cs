﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication5.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class eAirlinesEntities : DbContext
    {
        public eAirlinesEntities()
            : base("name=eAirlinesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ArrivalOrderView> ArrivalOrderView { get; set; }
        public virtual DbSet<movementsFlightsView> movementsFlightsView { get; set; }
        public virtual DbSet<DepartureOrderView> DepartureOrderView { get; set; }
    }
}