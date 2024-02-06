using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.SystemOperations.Exceptions
{
    internal class DonorException : Exception
    {
        public string ErrorMessage;
        public DonorException(string message) : base (message)
        {
            ErrorMessage = message;
        }
    }
}
