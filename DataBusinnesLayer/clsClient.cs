using DataAccessLayer;
using System;
using System.Data;


namespace DataBusinessLayer
{
    public class clsClient : clsPerson
    {
        enum enMode { AddNew = 0, Update = 1}
        enMode _Mode = enMode.AddNew;

        public int ID {  get; set; }
        public string AccountNumber { get; set; }
        public string ClientName { get; set; }
        public int PinCode { get; set; }
        public decimal AccountBalance { get; set; }
        public clsClient() 
        {
            ID = -1;
            AccountNumber = "";
            ClientName = "";
            PinCode = 0;
            AccountBalance = 0;
            Email = "";
            Phone = "";
        }

        clsClient(enMode mode,int id, string accountNumber, string clientName,
            int pinCode,string email,string phone, decimal accountBalance)
        {
            _Mode = mode;
            ID = id;
            AccountNumber = accountNumber;
            ClientName = clientName;
            PinCode = pinCode;
            AccountBalance = accountBalance;
            Email = email;
            Phone = phone;
        }

        public static clsClient FindClientByAccountNumber(string accountNumber)
        {
            string ClientName = "", Phone = "", Email = "";
            int PinCode = 0, ID = -1;decimal AccountBalance = 0;

            if(clsClientsDataAccess.FindClientByAccountNumber(accountNumber,ref ID,ref ClientName,ref Phone,
                ref Email,ref PinCode,ref AccountBalance))
            {
                return new clsClient(enMode.Update,ID,accountNumber,ClientName,PinCode,Email,Phone,AccountBalance);
            }
            else
                return null;
        }

        public static clsClient FindClientByID(int ID)
        {
            string ClientName = "", Phone = "", Email = "",AccountNumber="";
            int PinCode = 0;decimal AccountBalance = 0;

            if (clsClientsDataAccess.FindClientByID(ref AccountNumber, ID, ref ClientName, ref Phone, ref Email, ref PinCode, ref AccountBalance))
            {
                return new clsClient(enMode.Update, ID, AccountNumber, ClientName, PinCode, Email, Phone, AccountBalance);
            }
            else
                return null;
        }

        public static DataTable GetAllClients()
        {
            return clsClientsDataAccess.GetAllClients();
        }

        public static DataTable GetClientByAccountNumber(string AccountNumber)
        {
            string ClientName = "", Phone = "", Email = "";
            int PinCode = 0, ID = -1;decimal AccountBalance = 0;
            DataTable dt = clsClientsDataAccess.FindClientByAccount_Number(AccountNumber,ref ID,ref ClientName,ref Phone, ref Email,ref PinCode, ref AccountBalance);

            return dt;
        }

        public static bool DeleteClient(int ID)
        {
            return clsClientsDataAccess.DeleteClient(ID);
        }
        
        bool _AddNewClient()
        {
            this.ID = clsClientsDataAccess.AddNewClient(AccountNumber, ClientName,Phone,Email,PinCode,AccountBalance);

            return (ID != -1);
        }

        bool _UpdateClient()
        {
            return clsClientsDataAccess.UpdateClient(ID, AccountNumber, ClientName,Email,Phone,PinCode,AccountBalance);
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if(_AddNewClient())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateClient();
            }
            return false; 
        }
    }
}
