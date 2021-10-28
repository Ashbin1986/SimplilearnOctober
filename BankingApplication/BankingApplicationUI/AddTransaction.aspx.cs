using BusinessAccessLayer.IServices;
using BusinessAccessLayer.ServicesImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankingApplicationUI
{
    public partial class AddTransaction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int toAccount = 278637;//Convert.ToInt32(txtToAccount.Text);
            int fromAccount = 97852;//Convert.ToInt32(txtFromAccount.Text);
            decimal amount = Convert.ToDecimal(97852.56);//Convert.ToDecimal(txtAmount.Text);
            ITransactionService transactionService = new TransactionService();
            transactionService.AddTransaction(toAccount, fromAccount, amount);
        }
    }
}