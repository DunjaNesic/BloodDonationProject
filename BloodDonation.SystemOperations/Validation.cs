using BloodDonation.Common.Domain;
using BloodDonation.SystemOperations.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.SystemOperations
{
    public static class Validation
    {
        public static void ValidateDonor(this Donor donor, BloodTransfAction action = null) {
            if (donor.JMBG == null || donor.JMBG.Length != 13) throw new DonorException("JMBG mora sadržati tačno 13 brojeva");
            if (donor.DonorName == null || donor.DonorName.Length < 2) throw new DonorException("Ime nije napisano u ispravnom formatu");
            if (donor.DonorLastName == null || donor.DonorLastName.Length < 2) throw new DonorException("Prezime nije napisano u ispravnom formatu");
            if (donor.LastDonationDate == null || donor.LastDonationDate > DateTime.Now) throw new DonorException("Datum poslednjeg davanja krvi ne može biti u budućnosti");
            if (donor.IsActive == 0) throw new DonorException($"Davalac {donor.DonorName + " " + donor.DonorLastName} trenutno nije aktivan!");           
            //if (action != null)
            //{
            //    if (donor.Place == null)
            //    {
            //        if (action.PlaceID != donor.PlaceID) throw new DonorException($"Davalac {donor.DonorName + " " + donor.DonorLastName} ne daje krv u gradu {action.Place.PlaceName}");
            //    }
            //    else
            //    {
            //        if (action.PlaceID != donor.Place.PlaceID) throw new DonorException($"Davalac {donor.DonorName + " " + donor.DonorLastName} ne daje krv u gradu {action.Place.PlaceName}");
            //    }
            //}
        }

        public static void ValidateVolunteer(this Volunteer volunteer, BloodTransfAction action = null) {
            if (volunteer.VolunteerName == null || volunteer.VolunteerName.Length < 2) throw new VolunteerException("Ime nije napisano u ispravnom formatu");
            if (volunteer.VolunteerLastName == null || volunteer.VolunteerLastName.Length < 2) throw new VolunteerException("Prezime nije napisano u ispravnom formatu");
            if (volunteer.DateFreeFrom == null || volunteer.DateFreeTo == null || volunteer.DateFreeFrom > volunteer.DateFreeTo) throw new VolunteerException("Datum nije ispravno unet");            
            if (action != null) {
                if (volunteer.Place == null)
                {
                    if (action.PlaceID != volunteer.PlaceID) throw new VolunteerException($"Volonter {volunteer.VolunteerName + " " + volunteer.VolunteerLastName} ne volontira u gradu {action.Place.PlaceName}");
                }
                else { 
                    if (action.PlaceID != volunteer.Place.PlaceID) throw new VolunteerException($"Volonter {volunteer.VolunteerName + " " + volunteer.VolunteerLastName} ne volontira u gradu {action.Place.PlaceName}");
                }
            }
        }

        public static void ValidateAction(this BloodTransfAction action) {
            if (action.ActionName == null || action.ActionName == "" || action.ActionName.Length < 2) throw new ActionException("Ime akcije mora biti u ispravnom formatu");
            if (action.ActionTimeFromTo == null || action.ActionTimeFromTo == "") throw new ActionException("Satnica akcije mora biti uneta");
            if (action.ActionDate < DateTime.Now) throw new ActionException("Datum akcije mora biti u buducnosti");
        }

    }
}
