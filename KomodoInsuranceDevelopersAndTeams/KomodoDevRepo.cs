using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceDevelopersAndTeams
{
    public class KomodoDevRepo
    {
        protected readonly List<KomodoDeveloper> _listOfDevs = new List<KomodoDeveloper>();
        protected readonly List<KomodoTeam> _listofTeams = new List<KomodoTeam>();

        //Create
        public void AddDeveloper(KomodoDeveloper devToAdd)
        {
            _listOfDevs.Add(devToAdd);
        }

        public void AddTeam(KomodoTeam teamToAdd)
        {
            _listofTeams.Add(teamToAdd);
        }

        //Read
        public List<KomodoDeveloper> GetDevs()
        {
            return _listOfDevs;
        }
        
        public List<KomodoTeam> GetTeams()
        {
            return _listofTeams;
        }

        public KomodoDeveloper GetDeveloperByID(int id)
        {
            foreach (KomodoDeveloper developer in _listOfDevs)
            {
                if (id == developer.DeveloperID)
                {
                    return developer;
                }
            }
            return null;
        }

        public KomodoTeam GetTeamByID(int id)
        {
            foreach (KomodoTeam team in _listofTeams)
            {
                if (id == team.IDNumber)
                {
                    return team;
                }
            }
            return null;
        }

        //Update
        public void UpdateDeveloper(int id, KomodoDeveloper newDev)
        {
            KomodoDeveloper oldDev = GetDeveloperByID(id);

            oldDev.DeveloperID = newDev.DeveloperID;
            oldDev.LastName = newDev.LastName;
            oldDev.HasAccess = newDev.HasAccess;
        }

        public void UpdateTeam(int id, KomodoTeam newTeam)
        {
            KomodoTeam oldTeam = GetTeamByID(id);

            oldTeam.IDNumber = newTeam.IDNumber;
            oldTeam.TeamName = newTeam.TeamName;
            oldTeam.Developers = newTeam.Developers;
        }

        //Delete
        public void DeleteDeveloper(KomodoDeveloper developerToDelete)
        {
            _listOfDevs.Remove(developerToDelete);
        }

        public void DeleteTeam(KomodoTeam teamToDelete)
        {
            _listofTeams.Remove(teamToDelete);
        }
    }
}
