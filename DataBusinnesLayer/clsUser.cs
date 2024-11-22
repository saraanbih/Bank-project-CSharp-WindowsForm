using DataBusinessLayer;
using System;
using DataAccessLayer;
using System.Data;

namespace DataBusinessLayer
{
    public class clsUser : clsPerson
    {
         enum enMode { AddNew = 1,Update = 2 }
         enMode _Mode = enMode.AddNew;

        public int ID {  get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }

        public clsUser() 
        {
            this.ID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Phone = "";
            this.Password = "";
            this.Permissions = 0;
            this.Email = "";
            this.UserName = "";
        }

        private clsUser(enMode mode, int iD,string FirstName,string LastName,string Email,
            string Phone,string userName, string password, int permissions)
        {
            _Mode = mode;
            ID = iD;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            UserName = userName;
            Password = password;
            Permissions = permissions;
        }

       public enum enPermissions 
       {
            pAll = -1, pManageClients = 1, 
             pTransactions = 2, pManageUsers = 4,
            pLoginHistory = 8,pCurrencyExchange = 16
       }

        public static clsUser FindUserByUserNameAndID(string UserName,string Password)
        {
            string FirstName = "", LastName = "", Email = "", Phone = "";
            int Permissions = 0,ID=-1;
            if(clsUsersDataAccess.GetUserByUserNameAndPassword(UserName,Password,ref ID,ref FirstName,ref LastName,
                ref Phone,ref Email,ref Permissions))
            {
                return new clsUser(enMode.Update, ID, FirstName, LastName, Email, Phone, UserName, Password, Permissions);
            }
            return null;
        }

        public static DataTable GetAllUsers()
        {
            return clsUsersDataAccess.GetAllUsers();
        }
        
        public static clsUser FindUserByUserName(string UserName)
        {
            string FirstName = "", LastName = "", Email = "", Phone = "",Password="";
            int Permissions = 0, ID = -1;
            if(clsUsersDataAccess.FindUserByUserName(UserName,ref ID,ref FirstName,ref LastName,ref Phone,ref Email,ref Password,ref Permissions))
            {
                return new clsUser(enMode.Update, ID, FirstName, LastName, Email, Phone, UserName, Password, Permissions);
            }

            return null;
        }

        public static clsUser FindUserByID(int ID)
        {
            string FirstName = "", LastName = "", Email = "", Phone = "", Password = "",UserName="";
            int Permissions = 0;
            if (clsUsersDataAccess.FindUserByUserID(ref UserName, ID, ref FirstName, ref LastName, ref Phone, ref Email, ref Password, ref Permissions))
            {
                return new clsUser(enMode.Update, ID, FirstName, LastName, Email, Phone, UserName, Password, Permissions);
            }

            return null;
        }

        bool _AddNewUser()
        {
            this.ID = clsUsersDataAccess.AddNewUser(FirstName, LastName, Email, Phone, Password,Permissions,UserName);

            return (ID != -1);
        }

        bool _Update()
        {
            return clsUsersDataAccess.UpdateUser(ID, FirstName, LastName, Email, Phone, Password, Permissions);
        }

        public static bool DeleteUser(int ID)
        {
            return clsUsersDataAccess.DeleteUser(ID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _Update();
            }
            return false;
        }

    }
}
