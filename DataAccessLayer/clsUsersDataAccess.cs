using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class clsUsersDataAccess
    {
        public static bool GetUserByUserNameAndPassword(string UserName, string Password, ref int ID, ref string FirstName,
          ref string LastName, ref string Phone, ref string Email, ref int Permissions)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * from Users where UserName = @UserName and Password = @Password";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
             
            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    ID = (int)reader["ID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    Permissions = (int)reader["Permissions"];
                }
                reader.Close();
            }
            catch {  }
            finally {  Connection.Close(); }

            return IsFound;
        }

        public static DataTable GetAllUsers()
        {
            DataTable dataTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * from Users";

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

        public static bool FindUserByUserName(string UserName, ref int ID, ref string FirstName, ref string LastName,
           ref string Phone, ref string Email, ref string Password,ref int Permissions)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * from Users where UserName = @UserName";

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
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    Permissions = (int)reader["Permissions"];
                    Password = (string)reader["AccountBalance"];

                }
                reader.Close();
            }
            catch {  }
            finally { Connection.Close(); }

            return IsFound;
        }

        public static bool FindUserByUserID(ref string UserName, int ID, ref string FirstName, ref string LastName,
           ref string Phone, ref string Email, ref string Password, ref int Permissions)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * from Users where ID = @ID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID", ID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    UserName = (string)reader["UserName"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    Permissions = (int)reader["Permissions"];
                    Password = (string)reader["Password"];

                }
                reader.Close();
            }
            catch {  }
            finally { Connection.Close(); }

            return IsFound;
        }

        public static int AddNewUser(string FirstName, string LastName, string Phone, string Email,
       string Password, int Permissions, string UserName)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // Added Password column to the INSERT statement
            string Query = @"Insert into Users (FirstName, LastName, Phone, Email, UserName, Permissions, Password)
                     values (@FirstName, @LastName, @Phone, @Email, @UserName, @Permissions, @Password);
                     select SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@Password", Password);  // Password parameter added to the query
            Command.Parameters.AddWithValue("@Permissions", Permissions);
            Command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    return ID;
                }
            }
            catch (Exception ex)
            {
                // Optionally log the exception or handle it accordingly
                throw new Exception("Error while adding user", ex);
            }
            finally
            {
                Connection.Close();
            }

            return -1;
        }

        public static bool UpdateUser(int ID, string FirstName, string LastName, string Email,
         string Phone, string UserName,int Permissions)
        {

            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"Update Users set FirstName=@FirstName,FirstName=@FirstName, 
                          Email=@Email,Phone=@Phone,UserName=@UserName,Permissions=@Permissions 
                          where ID=@ID";

            SqlCommand command = new SqlCommand(Query, Connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Permissions", Permissions);

            try
            {

                Connection.Open();
                RowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex) { return false; }
            finally { Connection.Close(); }


            return (RowsAffected > 0);
        }

        public static bool DeleteUser(int ID)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Delete from Users where ID = @ID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID", ID);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch { }
            finally { Connection.Close(); }

            return RowsAffected > 0;
        }
    }
}
