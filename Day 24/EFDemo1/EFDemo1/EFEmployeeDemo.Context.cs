﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFDemo1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ExercisesDBEntities : DbContext
    {
        public ExercisesDBEntities()
            : base("name=ExercisesDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<COUNTRy> COUNTRIES { get; set; }
        public virtual DbSet<DEPARTMENT> DEPARTMENTS { get; set; }
        public virtual DbSet<EMPLOYEE> EMPLOYEES { get; set; }
        public virtual DbSet<JOB> JOBS { get; set; }
        public virtual DbSet<LOCATION> LOCATIONS { get; set; }
        public virtual DbSet<REGION> REGIONS { get; set; }
        public virtual DbSet<customer> customers { get; set; }
    }
}
