using BusinessAccessLayer.IServices;
using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.ServicesImplementation
{
    public class TransactionService : ITransactionService
    {
        IDBRepository _dBRepository;
        public int AddTransaction(int transferToAccount, int transferFromAccount, decimal transferAmount)
        {
            _dBRepository = new DBRepository();
             return _dBRepository.AddTransaction(transferToAccount,transferFromAccount, transferAmount);
        }

        public int DeleteTransaction(int transactionId)
        {
            _dBRepository = new DBRepository();
            return _dBRepository.DeleteTransaction(transactionId);
        }

        public DataSet GetTransactions()
        {
            _dBRepository = new DBRepository();
            return _dBRepository.GetTransactions();
        }
    }
}
