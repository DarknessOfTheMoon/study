﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace course_work_3_0.model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class STUDENTSEntities : DbContext
    {
        public STUDENTSEntities()
            : base("name=STUDENTSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<FACULTY> FACULTY { get; set; }
        public virtual DbSet<GROUP> GROUP { get; set; }
        public virtual DbSet<SPECIALTY> SPECIALTY { get; set; }
        public virtual DbSet<students> students { get; set; }
    }
}
