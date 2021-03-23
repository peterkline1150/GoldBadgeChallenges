using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceDevelopersAndTeams
{
    public class KomodoTeam
    {
        public string TeamName { get; set; }
        public int IDNumber { get; set; }
        public List<KomodoDeveloper> Developers { get; set; } = new List<KomodoDeveloper>();

        public KomodoTeam()
        {

        }

        public KomodoTeam(List<KomodoDeveloper> developers, int idNumber, string teamName)
        {
            Developers = developers;
            IDNumber = idNumber;
            TeamName = teamName;
        }

        public void AddDeveloper(KomodoDeveloper developer)
        {
            Developers.Add(developer);
        }

        public void DeleteDeveloper(KomodoDeveloper developer)
        {
            Developers.Remove(developer);
        }
    }
}
