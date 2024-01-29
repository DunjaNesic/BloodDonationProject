
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Client.Exceptions
{
    public class ServerCommunicationException : Exception
    {
        string ErrorMessage;
        public ServerCommunicationException(string message) : base(message) 
        {
            ErrorMessage = message;
        }
    }
}
