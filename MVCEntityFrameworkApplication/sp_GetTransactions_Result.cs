//------------------------------------------------------------------------------
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
    
    public partial class sp_GetTransactions_Result
    {
        public int TransactionId { get; set; }
        public Nullable<int> TransferToAccount { get; set; }
        public Nullable<int> TransferFromAccount { get; set; }
        public Nullable<decimal> TransferAmount { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
    }
}
