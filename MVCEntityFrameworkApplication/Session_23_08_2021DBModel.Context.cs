﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCEntityFrameworkApplication
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Session_23_08_2021DBEntities : DbContext
    {
        public Session_23_08_2021DBEntities()
            : base("name=Session_23_08_2021DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Emo_Project_Mapping> Emo_Project_Mapping { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<TransactionDetail> TransactionDetails { get; set; }
        public virtual DbSet<UserLogin> UserLogins { get; set; }
        public virtual DbSet<Employee_Det> Employee_Det { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
    
        public virtual int sp_AddTrasaction(Nullable<int> transferToAccount, Nullable<int> transferFromAccount, Nullable<decimal> transferAmount)
        {
            var transferToAccountParameter = transferToAccount.HasValue ?
                new ObjectParameter("transferToAccount", transferToAccount) :
                new ObjectParameter("transferToAccount", typeof(int));
    
            var transferFromAccountParameter = transferFromAccount.HasValue ?
                new ObjectParameter("transferFromAccount", transferFromAccount) :
                new ObjectParameter("transferFromAccount", typeof(int));
    
            var transferAmountParameter = transferAmount.HasValue ?
                new ObjectParameter("transferAmount", transferAmount) :
                new ObjectParameter("transferAmount", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AddTrasaction", transferToAccountParameter, transferFromAccountParameter, transferAmountParameter);
        }
    
        public virtual int sp_DeleteTransaction(Nullable<int> transactionId)
        {
            var transactionIdParameter = transactionId.HasValue ?
                new ObjectParameter("transactionId", transactionId) :
                new ObjectParameter("transactionId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DeleteTransaction", transactionIdParameter);
        }
    
        public virtual ObjectResult<sp_GetTransactions_Result> sp_GetTransactions()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetTransactions_Result>("sp_GetTransactions");
        }
    }
}
