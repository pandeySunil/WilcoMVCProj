﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace WilcoCon.Models
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class WilcoEntities : DbContext
{
    public WilcoEntities()
        : base("name=WilcoEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<JobClassification> JobClassifications { get; set; }

    public virtual DbSet<PayScale> PayScales { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<TimeCard> TimeCards { get; set; }

    public virtual DbSet<UserProfile> UserProfiles { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

}

}
