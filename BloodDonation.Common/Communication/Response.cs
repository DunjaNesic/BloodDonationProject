using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Common.Communication
{
    [Serializable]
    public class Response
    {
        public object Result { get; set; }
        public bool IsSuccessful { get; set; } = true;
        public string Message { get; set; }
        public string ErrorMessage { get; set; }
        public Exception Exception { get; set; }

    }
}
