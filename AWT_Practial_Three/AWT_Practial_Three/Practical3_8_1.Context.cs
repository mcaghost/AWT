﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AWT_Practial_Three
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class customer_info_Entities1 : DbContext
    {
        public customer_info_Entities1()
            : base("name=customer_info_Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<customer_info> customer_info { get; set; }
        public virtual DbSet<emp_info> emp_info { get; set; }
        public virtual DbSet<ProductDetail> ProductDetails { get; set; }
    }
}
