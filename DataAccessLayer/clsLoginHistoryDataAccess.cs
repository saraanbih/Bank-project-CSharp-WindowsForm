using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class clsLoginHistoryDataAccess
    {
        public static DataTable GetLoginHistory()
        {
            DataTable dataTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * from LoginHistory";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    dataTable.Load(Reader);

                Reader.Close();
            }
            catch { }
            finally { Connection.Close(); }

            return dataTable;
        }

        public static int AddNewLoginRecord(DateTime LoginDateTime,string UserName,string Password,int Permissions)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // Added Password column to the INSERT statement
            string Query = @"Insert into LoginHistory (LoginDateTime, UserName, Password, Permissions)
                     values (@LoginDateTime, @UserName, @Password, @Permissions);
                     select SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LoginDateTime", LoginDateTime);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@Permissions", Permissions);           

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    return ID;
                }
            }
            catch {  }
            finally
            {
                Connection.Close();
            }

            return -1;
        }

        public static bool FindUserByUserName(string UserName, ref int ID, ref string Password, ref DateTime LoginDateTime,
           ref int Permissions)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * from LoginHistory where UserName = @UserName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    ID = (int)reader["ID"];               
                    LoginDateTime = (DateTime)reader["LoginDateTime"];
                    Permissions = (int)reader["Permissions"];
                    Password = (string)reader["AccountBalance"];

                }
                reader.Close();
            }
            catch { }
            finally { Connection.Close(); }

            return IsFound;
        }

        public static DataTable FindUserByUserName(string UserName)
        {
            DataTable dataTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * from LoginHistory where UserName = @UserName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);

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
    }
}
