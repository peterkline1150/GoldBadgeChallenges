using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTeamPart1
{
    public class KomodoInsuranceDeveloper
    {
        public int DeveloperID { get; set; }
        public string LastName { get; set; }
        public bool HasAccess { get; set; }

        public KomodoInsuranceDeveloper()
        {

        }

        public KomodoInsuranceDeveloper(int developerID, string lastName, bool hasAccess)
        {
            DeveloperID = developerID;
            LastName = lastName;
            HasAccess = hasAccess;
        }
    }
}
