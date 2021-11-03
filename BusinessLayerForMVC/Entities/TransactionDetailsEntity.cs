using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerForMVC.Entities
{
    public class TransactionDetailsEntity
    {
        public int TransactionId { get; set; }
        public int? TransferToAccount { get; set; }
        public int? TransferFromAccount { get; set; }
        public Nullable<decimal> TransferAmount { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
    }
}
