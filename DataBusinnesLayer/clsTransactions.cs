using System;
using System.Data;
using DataAccessLayer;


namespace DataBusinessLayer
{
    public class clsTransactions
    {
        public static DataTable GetClientsInfo()
        {
            return clsTransactionsDataAccess.GetClientsInfo();
        }

        public static DataTable GetClientInfoByAccountNumber(string AccountNumber)
        {
            return clsTransactionsDataAccess.FindClientByAccount_Number(AccountNumber);
        }

        public static bool Deposit(int ID,decimal Amount)
        {
            return clsTransactionsDataAccess.Deposit(ID, Amount);
        }

        public static bool Withdraw(int ID, decimal Amount)
        {
            return clsTransactionsDataAccess.Withdraw(ID, Amount);
        }

        public static bool Transfer(int SenderID,int ReceiverID,decimal Amount,clsUser User,clsClient ClientS,clsClient ClientR)
        {
            return clsTransactionsDataAccess.Transfer(SenderID,ReceiverID,Amount,User.UserName,ClientS.AccountBalance,
                ClientR.AccountBalance,ClientS.AccountNumber,ClientS.AccountNumber);
        }

        public static DataTable TransferLog()
        {
            return clsTransactionsDataAccess.GetTransferLog();
        }

    }
}
