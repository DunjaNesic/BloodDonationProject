using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Client.Exceptions
{
    public class SystemOperationException : Exception
    {
        public string ErrorMessage;

        public SystemOperationException(string message)
        {
            ErrorMessage = message;
        }
    }
}
