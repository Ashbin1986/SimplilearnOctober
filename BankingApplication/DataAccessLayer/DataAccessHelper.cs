using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public static class DataAccessHelper
    {
        static SqlConnection sqlConnection;
        static SqlCommand sqlCommand;
        static SqlDataAdapter sqlDataAdapter;
        static DataSet dst;
        public static void CreateConnection()
        {
            sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=Session_23_08_2021DB;Integrated Security=True;");
        }

        public static void CloseConnection()
        {
            sqlConnection.Close();
        }
        public static void OpenConnection()
        {
            sqlConnection.Open();
        }

        public static int AddTransaction(int transferToAccount , int transferFromAccount , decimal transferAmount)
        {
            CreateConnection();
           
            sqlCommand = new SqlCommand("sp_AddTrasaction", sqlConnection);
            
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@transferToAccount", transferToAccount);
            sqlCommand.Parameters.AddWithValue("@transferFromAccount", transferFromAccount);
            sqlCommand.Parameters.AddWithValue("@transferAmount", transferAmount);
            OpenConnection();
            int isAdded = sqlCommand.ExecuteNonQuery();
            CloseConnection();
            return isAdded;
        }

        public static DataSet GetTransactions()
        {
            CreateConnection();
            sqlDataAdapter = new SqlDataAdapter("sp_GetTransactions", sqlConnection);
            dst = new DataSet();
            sqlDataAdapter.Fill(dst, "Transaction");
            return dst;
        }

        public static int DeleteTransaction(int transactionId)
        {
            CreateConnection();

            sqlCommand = new SqlCommand("sp_DeleteTransaction", sqlConnection);

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@transactionId", transactionId);
            OpenConnection();
            int isDeleted = sqlCommand.ExecuteNonQuery();
            CloseConnection();
            return isDeleted;
        }
    }
}
