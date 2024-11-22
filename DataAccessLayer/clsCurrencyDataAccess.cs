using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class clsCurrencyDataAccess
    {
        public static DataTable GetAllCurrencies()
        {
            DataTable dataTable = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * from Currencies";

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

        public static DataTable FindCurrencyByCurrencyCode(string CurrencyCode)
        {
            DataTable dataTable = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM Currencies WHERE CurrencyCode = @CurrencyCode";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CurrencyCode", CurrencyCode.ToUpper());

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
            catch  { }
            finally
            {
                Connection.Close();
            }

            return dataTable;
        }

        public static bool FindCurrencyByCurrencyCode(string CurrencyCode,ref int ID,ref string Country,
            ref string CurrencyName,ref float Rate)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM Currencies WHERE CurrencyCode = @CurrencyCode";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CurrencyCode", CurrencyCode.ToUpper());

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    ID = (int)reader["ID"];
                    Country = (string)reader["Country"];
                    CurrencyCode = (string)reader["CurrencyCode"];
                    Rate = (float)reader.GetDouble(reader.GetOrdinal("ExchangeRateUSD"));
                    CurrencyName = (string)reader["CurrencyName"];
                }

                reader.Close();
            }
            catch { }
            finally
            {
                Connection.Close();
            }

            return IsFound;
        }

        public static bool UpdateRate(string CurrencyCode, string CurrencyName, float ExchangeRateUSD, string Country)
        {
            int RowsAffected = 0;
            string connectionString = clsDataAccessSettings.ConnectionString;

            string Query = @"UPDATE Currencies 
                     SET CurrencyName = @CurrencyName, 
                         ExchangeRateUSD = @ExchangeRateUSD, 
                         Country = @Country
                     WHERE CurrencyCode = @CurrencyCode";
            SqlConnection Connection = new SqlConnection(connectionString);
            SqlCommand Command = new SqlCommand(Query, Connection); 
            
            Command.Parameters.AddWithValue("@CurrencyCode", CurrencyCode);
            Command.Parameters.AddWithValue("@CurrencyName", CurrencyName);
            Command.Parameters.AddWithValue("@ExchangeRateUSD", ExchangeRateUSD);
            Command.Parameters.AddWithValue("@Country", Country);

            try
            {            
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }           
            catch 
            { }
            finally { Connection.Close(); }
            // Return true if at least one row was updated, otherwise false
            return (RowsAffected > 0);
        }

    }
}
