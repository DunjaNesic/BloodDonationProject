using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.SystemOperations.Exceptions
{
    internal class VolunteerException : Exception
    {
        public string ErrorMessage;
        public VolunteerException(string message) : base(message)
        {
            ErrorMessage = message;
        }
    }
}
