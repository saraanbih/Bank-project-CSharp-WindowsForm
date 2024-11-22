using DataAccessLayer;
using DataBusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataBusinessLayer
{
    public class clsCurrency
    {
        public int ID { get; set; }
        public string Country { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
        public float ExchangeRateUSD { get; set; }

        public static DataTable GetAllCurrencies()
        {
            return clsCurrencyDataAccess.GetAllCurrencies();
        }

        clsCurrency(int iD, string country, string currencyName, string currencyCode, float exchangeRateUSD)
        {
            ID = iD;
            Country = country;
            CurrencyName = currencyName;
            CurrencyCode = currencyCode;
            ExchangeRateUSD = exchangeRateUSD;
        }

        public clsCurrency()
        {
            ID = -1;
            Country = "";
            CurrencyCode = "";
            ExchangeRateUSD = 0;
            CurrencyName = "";
        }

        public static DataTable FindCurrencyByCurrencyCode(string CurrencyCode)
        {           
            DataTable dataTable = clsCurrencyDataAccess.FindCurrencyByCurrencyCode(CurrencyCode);

            return dataTable;
        }

        public static clsCurrency FindCurrency_CurrencyCode(string CurrencyCode)
        {
            string CurrencyName = "", Country = "";float Rate = 0;
            int ID = -1;
            if (clsCurrencyDataAccess.FindCurrencyByCurrencyCode(CurrencyCode,ref ID,ref Country,ref CurrencyName,ref Rate))
            {
                return new clsCurrency(ID, Country, CurrencyName, CurrencyCode, Rate);
            }

            return null;
        }

        public static bool Update(string CurrencyCode,string CurrencyName,string Country,float Rate)
        {
             return clsCurrencyDataAccess.UpdateRate(CurrencyCode,CurrencyName,Rate,Country);
        }
    }
}
