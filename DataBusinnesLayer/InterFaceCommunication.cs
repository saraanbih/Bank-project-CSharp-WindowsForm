using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusinessLayer
{
    interface InterFaceCommunication
    {
        void SendEmail(string Title, string Body); 
        void SendFax(string Title, string Body);
        void SendSMS(string Title, string Body);
    }
}
