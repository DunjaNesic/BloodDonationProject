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
        LoadVolunteer,
        DeleteVolunteer,
        GetAllVolunteers,
        CreateDonor,
        FindDonor,
        FindDonors,
        DeleteDonor,
        GetAllDonors,
        UpdateDonor,
        CreateCallToAction,
        UpdateCallToAction,
        FindVolunteerCalls,
        FindDonorCalls,
        LoadAction,
        DeleteAction,
        GetAllActions,
        FindActions,
        GetAllPlaces,
        GetAllQuestionnaires,
        Close
    }
}
