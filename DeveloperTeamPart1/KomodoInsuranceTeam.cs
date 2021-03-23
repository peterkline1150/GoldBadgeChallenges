using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTeamPart1
{
    public class KomodoInsuranceTeam
    {
        public string TeamName { get; set; }
        public int IDNumber { get; set; }
        public List<KomodoInsuranceDeveloper> Developers { get; set; }

        public KomodoInsuranceTeam()
        {

        }

        public KomodoInsuranceTeam(List<KomodoInsuranceDeveloper> developers, int idNumber, string teamName)
        {
            Developers = developers;
            IDNumber = idNumber;
            TeamName = teamName;
        }

        public void AddMember(KomodoInsuranceDeveloper devToAdd)
        {
            Developers.Add(devToAdd);
        }

        public void DeleteMemberByID(int id)
        {
            foreach (KomodoInsuranceDeveloper developer in Developers)
            {
                if (id == developer.DeveloperID)
                {
                    Developers.Remove(developer);
                }
            }
        }
    }
}
