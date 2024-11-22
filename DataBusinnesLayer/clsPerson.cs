using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusinessLayer
{
    public class clsPerson : InterFaceCommunication
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public clsPerson(string FirstName,string LastName,string Email,string Phone) 
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
        }

        public clsPerson() { }  

         public void SendEmail(string Title, string Body)
         { }
        public void SendFax(string Title, string Body)
        { }
        public void SendSMS(string Title, string Body)
        { }

    }
}
