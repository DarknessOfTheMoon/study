﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChainOfStores.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ChainOfStoresEntities1 : DbContext
    {
        public ChainOfStoresEntities1()
            : base("name=ChainOfStoresEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<OWNER> OWNER { get; set; }
        public virtual DbSet<PROFILE> PROFILE { get; set; }
        public virtual DbSet<PROVIDER> PROVIDER { get; set; }
        public virtual DbSet<STORE> STORE { get; set; }
        public virtual DbSet<SUPPLY> SUPPLY { get; set; }
    }
}
