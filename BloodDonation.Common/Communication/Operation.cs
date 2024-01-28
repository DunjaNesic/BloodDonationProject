using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Common.Communication
{
    public enum Operation
    {
        Login, 
        CreateVolunteer,
        FindVolunteers,
        DeleteVolunteer,
        GetAllVolunteers,
        CreateDonor,
        FindDonor,
        DeleteDonor,
        GetAllDonors,
        UpdateDonor,
        CreateCallToAction,
        UpdateCallToAction,
        FindCallToAction,
        LoadAction,
        GetAllActions,
        GetAllCallsToAction,
        GetAllPlaces,
        GetAllQuestionnaires

    }
}
