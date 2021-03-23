using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceDevelopersAndTeams
{
    public class KomodoDeveloper
    {
        public int DeveloperID { get; set; }
        public string LastName { get; set; }
        public bool HasAccess { get; set; }

        public KomodoDeveloper()
        {

        }

        public KomodoDeveloper(int developerID, string lastName, bool hasAccess)
        {
            DeveloperID = developerID;
            LastName = lastName;
            HasAccess = hasAccess;
        }
    }
}
