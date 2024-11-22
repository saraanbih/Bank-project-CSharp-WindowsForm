using DataAccessLayer;
using DataBusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusinnesLayer
{
    public class clsLoginHistory
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime LoginDateTime { get; set; }
        public int Permissions { get; set; } 
        
        public clsLoginHistory() 
        {
            ID = -1;
            UserName = "";
            Password = "";
            LoginDateTime = DateTime.Now;
            Permissions = 0;
        }
        clsLoginHistory(int id,string username,string password,string loginhistory,DateTime dateTime,int permissions)
        {
            ID = id;
            UserName = username;
            Password = password;
            LoginDateTime = dateTime;
            Permissions = permissions;
        }

        public static bool FindByUserName(string userName)
        {
            int ID = -1, Permissions = 0;
            string Password = "";DateTime dateTime = DateTime.Now;

            return clsLoginHistoryDataAccess.FindUserByUserName(userName,ref ID,ref Password,ref dateTime,ref Permissions);
        }

        public static DataTable FindByUser_Name(string userName)
        {
            return clsLoginHistoryDataAccess.FindUserByUserName(userName);
        }
    
        public static DataTable GetLoginHistory()
        {
            return clsLoginHistoryDataAccess.GetLoginHistory();
        }

        public static bool AddNewRecoerd(clsUser User)
        {
            return (clsLoginHistoryDataAccess.AddNewLoginRecord(DateTime.Now, User.UserName, User.Password, User.Permissions) != -1);
        }
    }
}
