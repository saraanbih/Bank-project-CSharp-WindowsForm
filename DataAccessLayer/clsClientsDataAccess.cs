using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq.Expressions;

namespace DataAccessLayer
{
    public static class clsClientsDataAccess
    {
        public static DataTable FindClientByAccount_Number(string AccountNumber,ref int ID, ref string ClientName, ref string Phone,
            ref string Email, ref int PinCode, ref decimal AccountBalance)
        {
            DataTable dataTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * from Clients where AccountNumber = @AccountNumber";

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

        public static bool FindClientByAccountNumber(string AccountNumber, ref int ID, ref string ClientName, ref string Phone,
            ref string Email, ref int PinCode, ref decimal AccountBalance)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * from Clients where AccountNumber = @AccountNumber";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    ID = (int)reader["ID"];
                    AccountNumber = (string)reader["AccountNumber"];
                    ClientName = (string)reader["ClientName"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    PinCode = (int)reader["PinCode"];
                    AccountBalance = (decimal)reader["AccountBalance"];
                    
                }
                reader.Close();
            }
            catch { }
            finally { Connection.Close(); }

            return IsFound;
        }

        public static bool FindClientByID(ref string AccountNumber, int ID, ref string ClientName, ref string Phone,
           ref string Email, ref int PinCode, ref decimal AccountBalance)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * from Clients where ID = @ID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID", ID);


            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    AccountNumber = (string)reader["AccountNumber"];
                    ClientName = (string)reader["ClientName"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    PinCode = (int)reader["PinCode"];
                    AccountBalance = (decimal)reader["AccountBalance"];
                }
                reader.Close();
            }
            catch { }
            finally { Connection.Close(); }

            return IsFound;
        }

        public static DataTable GetAllClients()
        {
            DataTable dataTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * from Clients";

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

        public static int AddNewClient(string AccountNumber,string ClientName,string Phone,string Email,int PinCode,
            decimal AccountBalance)
        {         
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"Insert into Clients (AccountNumber,ClientName,Phone,Email,PinCode,AccountBalance)
                              values (@AccountNumber,@ClientName,@Phone,@Email,@PinCode,@AccountBalance);
                              select SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand (Query, Connection);
            Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            Command.Parameters.AddWithValue("@ClientName", ClientName);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@PinCode", PinCode);
            Command.Parameters.AddWithValue("@AccountBalance", AccountBalance);

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    return ID;
                }
            }
            catch { }
            finally { Connection.Close(); }

            return -1;
        }

        public static bool DeleteClient(int ID)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection (clsDataAccessSettings.ConnectionString);

            string Query = "Delete from Clients where ID = @ID";
            SqlCommand Command = new SqlCommand (Query, Connection);
            Command.Parameters.AddWithValue ("@ID", ID);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch { }
            finally { Connection.Close(); }

            return RowsAffected > 0;
        }

        public static bool UpdateClient(int ID, string AccountNumber, string ClientName, string Email,
         string Phone, int PinCode, decimal AccountBalance)
        {

            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"Update Clients set AccountNumber=@AccountNumber,ClientName=@ClientName, 
                          Email=@Email,Phone=@Phone,PinCode=@PinCode,AccountBalance=@AccountBalance 
                          where ID=@ID";

            SqlCommand command = new SqlCommand(Query, Connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@ClientName", ClientName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);

            try
            {

                Connection.Open();
                RowsAffected = command.ExecuteNonQuery();

            }
            catch {  }
            finally { Connection.Close(); }


            return (RowsAffected > 0);
        }
    }
}
