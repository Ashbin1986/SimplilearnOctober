﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ECommerceWebAPI
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class ECommerceDBEntities : DbContext
    {
        public ECommerceDBEntities()
            : base("name=ECommerceDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    
        [EdmFunction("ECommerceDBEntities", "GetRecords")]
        public virtual IQueryable<GetRecords_Result> GetRecords(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GetRecords_Result>("[ECommerceDBEntities].[GetRecords](@id)", idParameter);
        }
    
        public virtual ObjectResult<GetProducts_Result> GetProducts(Nullable<int> categoryId)
        {
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("categoryId", categoryId) :
                new ObjectParameter("categoryId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetProducts_Result>("GetProducts", categoryIdParameter);
        }
    }
}
