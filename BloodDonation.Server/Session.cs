using BloodDonation.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Server
{
    internal class Session
    {
        public static List<TransfusionCenterCoordinator> currentlyLoggedCoords = new List<TransfusionCenterCoordinator>();
    }
}
