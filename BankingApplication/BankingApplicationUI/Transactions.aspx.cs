using BusinessAccessLayer.IServices;
using BusinessAccessLayer.ServicesImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BankingApplicationUI.Constants;

namespace BankingApplicationUI
{
    public partial class Transactions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LoadTransactions();
            }
        }

        private void LoadTransactions()
        {
            ITransactionService transactionService = new TransactionService();
            var transactions = transactionService.GetTransactions();
            gvTransactions.DataSource = transactions;
            gvTransactions.DataBind();

        }

        protected void lnkDelete_Command(object sender, EventArgs e)
        {
            LinkButton link = sender as LinkButton;
            if (link.CommandName == ActionConstants.DELETE.ToString())
            {
                ITransactionService transactionService = new TransactionService();

                int transactionId = Convert.ToInt32(link.CommandArgument);

                var transactions = transactionService.DeleteTransaction(transactionId);

                LoadTransactions();
            }
        }

    }
}