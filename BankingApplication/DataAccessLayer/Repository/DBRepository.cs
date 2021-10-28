using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class DBRepository : IDBRepository
    {
        public int AddTransaction(int transferToAccount, int transferFromAccount, decimal transferAmount)
        {
            return DataAccessHelper.AddTransaction(transferToAccount, transferFromAccount, transferAmount);
        }

        public int DeleteTransaction(int transactionId)
        {
            return DataAccessHelper.DeleteTransaction(transactionId);
        }

        public DataSet GetTransactions()
        {
            return DataAccessHelper.GetTransactions();
        }
    }
}
