using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace DataAccessLayer
{
    public class clsTransactionsDataAccess
    {
        public static DataTable GetClientsInfo()
        {
            DataTable dataTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select ID,ClientName,AccountNumber,PinCode,AccountBalance from Clients";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                    dataTable.Load(Reader);

                Reader.Close();
            }
            catch { }
            finally { Connection.Close(); }



            return dataTable;
        }

        public static DataTable FindClientByAccount_Number(string AccountNumber)
        {
            DataTable dataTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select ID,AccountNumber,ClientName,PinCode,AccountBalance from Clients where AccountNumber = @AccountNumber";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
                reader.Close();
            }
            catch { }
            finally { Connection.Close(); }

            return dataTable;
        }

        public static bool Deposit(int ID,decimal Amount)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "UPDATE Clients SET AccountBalance = AccountBalance + @Amount WHERE ID = @ID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ID", ID);
            Command.Parameters.AddWithValue("@Amount", Amount);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();

            }
            catch { }
            finally { Connection.Close(); }

            return RowsAffected > 0;
        }

        public static bool Withdraw(int ID, decimal Amount)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "UPDATE Clients SET AccountBalance = AccountBalance - @Amount WHERE ID = @ID and AccountBalance >= @Amount";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@ID", ID);
            Command.Parameters.AddWithValue("@Amount", Amount);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();

            }
            catch { }
            finally { Connection.Close(); }

            return RowsAffected > 0;
        }

        public static int TotalBalances()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select SUM(AccountBalance) from Clients";

            SqlCommand Command = new SqlCommand(@Query, Connection);

            try
            {
                Connection.Open();
                object result = Command.ExecuteScalar();

                return (result != DBNull.Value) ? Convert.ToInt32(result) : 0;
            }
            catch { }
            finally { Connection.Close(); }

            return 0;
        }

        public static bool Transfer(int SenderID, int ReceiverID, decimal Amount, string User,
        decimal AccountBalanceS, decimal AccountBalanceR, string AccountNumberS, string AccountNumberR)
        {
            bool Completed = false;

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                Connection.Open();  // Open connection before transaction
                SqlTransaction transaction = Connection.BeginTransaction();

                try
                {
                    // Query to deduct amount from the sender's account
                    string QuerySender = "UPDATE Clients SET AccountBalance = AccountBalance - @Amount WHERE ID = @SenderID";
                    SqlCommand Command1 = new SqlCommand(QuerySender, Connection, transaction);
                    Command1.Parameters.AddWithValue("@Amount", Amount);
                    Command1.Parameters.AddWithValue("@SenderID", SenderID);
                    Command1.ExecuteNonQuery();

                    // Query to add amount to the receiver's account
                    string QueryReceiver = "UPDATE Clients SET AccountBalance = AccountBalance + @Amount WHERE ID = @ReceiverID";
                    SqlCommand Command2 = new SqlCommand(QueryReceiver, Connection, transaction);
                    Command2.Parameters.AddWithValue("@Amount", Amount);
                    Command2.Parameters.AddWithValue("@ReceiverID", ReceiverID);
                    Command2.ExecuteNonQuery();

                    // Query to log the transaction in the TransferLog table
                    string QueryLog = @"
                     INSERT INTO TransferLog 
                     ( [TransferLog DateTime],[Source Account Number], [Destination Account Number], Amount, [Source Balance], [Destination Balance], [User]) 
                    VALUES (@DateTime,@AccountNumberS, @AccountNumberR, @Amount, @SourceBalance, @DestinationBalance, @User)";
                    SqlCommand Command3 = new SqlCommand(QueryLog, Connection, transaction);

                    // Set parameters for the transfer log
                    Command3.Parameters.AddWithValue("@AccountNumberS", AccountNumberS);  // Sender's account number
                    Command3.Parameters.AddWithValue("@AccountNumberR", AccountNumberR);  // Receiver's account number
                    Command3.Parameters.AddWithValue("@Amount", Amount);  // Transaction amount
                    Command3.Parameters.AddWithValue("@SourceBalance", AccountBalanceS);  // Sender's account balance
                    Command3.Parameters.AddWithValue("@DestinationBalance", AccountBalanceR);  // Receiver's account balance
                    Command3.Parameters.AddWithValue("@User", User);  // User performing the transaction
                    Command3.Parameters.AddWithValue("@DateTime", DateTime.Now);  // Current timestamp

                    Command3.ExecuteNonQuery();

                    // Commit the transaction if all queries are successful
                    transaction.Commit();
                    Completed = true;
                }
                catch (Exception ex)
                {
                    // Rollback the transaction if any error occurs
                    transaction.Rollback();
                    Console.WriteLine(ex.Message);  // Handle or log the exception
                }
                finally
                {
                    // Always close the connection
                    Connection.Close();
                }
            }

            return Completed;
        }



        public static DataTable GetTransferLog()
        {
            DataTable TransferLog = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * from TransferLog";

            SqlCommand Command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                // Directly load all rows from the reader to the DataTable
                TransferLog.Load(reader);

                reader.Close();
            }
            catch { }
            finally { connection .Close(); }


            return TransferLog;
        }

   

    }
}
