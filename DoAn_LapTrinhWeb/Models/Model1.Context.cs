﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn_LapTrinhWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class kaomeEntities : DbContext
    {
        public kaomeEntities()
            : base("name=kaomeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountAddress> AccountAddresses { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Delivery> Deliveries { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Oder_Detail> Oder_Detail { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderAddress> OrderAddresses { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<ReplyFeedback> ReplyFeedbacks { get; set; }
        public virtual DbSet<Ward> Wards { get; set; }
    }
}
