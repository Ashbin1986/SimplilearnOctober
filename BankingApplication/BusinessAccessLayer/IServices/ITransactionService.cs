using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.IServices
{
    public interface ITransactionService
    {
        int AddTransaction(int transferToAccount, int transferFromAccount, decimal transferAmount);
        DataSet GetTransactions();
        int DeleteTransaction(int transactionId);

    }
}
