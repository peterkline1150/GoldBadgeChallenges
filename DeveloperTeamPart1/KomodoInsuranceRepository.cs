using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTeamPart1
{
    public class KomodoInsuranceRepository
    {
        protected readonly List<KomodoInsuranceDeveloper> _listOfDevs = new List<KomodoInsuranceDeveloper>();
        protected readonly List<KomodoInsuranceTeam> _listOfTeams = new List<KomodoInsuranceTeam>();

        public void CreateDeveloper()
        {
            KomodoInsuranceDeveloper newDev = new KomodoInsuranceDeveloper();

            Console.WriteLine("Enter the Developer ID:");
            int id = int.Parse(Console.ReadLine());
            newDev.DeveloperID = id;

            Console.WriteLine("Enter the Developer's Last Name:");
            string lastName = Console.ReadLine();
            newDev.LastName = lastName;

            Console.WriteLine("Does the Developer have access? (y/n):");
            char access = char.Parse(Console.ReadLine());

            bool hasAccess;
            if (access == 'y')
            {
                hasAccess = true;
            }
            else
            {
                hasAccess = false;
            }
            newDev.HasAccess = hasAccess;

            _listOfDevs.Add(newDev);
        }

        public void CreateTeams()
        {
            KomodoInsuranceTeam newTeam = new KomodoInsuranceTeam();

            Console.WriteLine("Enter the name of your new team:");
            newTeam.TeamName = Console.ReadLine();
            Console.WriteLine("Enter the ID number of your new team:");
            int idNumber = int.Parse(Console.ReadLine());
            newTeam.IDNumber = idNumber;

            bool continueToAdd = true;

            while (continueToAdd)
            {
                Console.WriteLine("Choose which Developers to add to the team");

                int count = 0;
                foreach (KomodoInsuranceDeveloper developer in _listOfDevs)
                {
                    count++;
                    Console.WriteLine($"{count}: ID: {developer.DeveloperID}\n" +
                        $"Name: {developer.LastName}\n" +
                        $"Has Access: {developer.HasAccess}\n");
                }

                int choice = int.Parse(Console.ReadLine());

                if (choice > 0 && choice <= count)
                {
                    newTeam.AddMember(_listOfDevs[choice - 1]);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

                Console.WriteLine("Do you wish to continue adding members to your team? (y/n):");
                char answer = char.Parse(Console.ReadLine());
                if (answer == 'y')
                {
                    continueToAdd = true;
                }
                else
                {
                    continueToAdd = false;
                }
            }

            _listOfTeams.Add(newTeam);
        }

        public List<KomodoInsuranceDeveloper> GetDevs()
        {
            return _listOfDevs;
        }

        public List<KomodoInsuranceTeam> GetTeams()
        {
            return _listOfTeams;
        }

        public KomodoInsuranceTeam UpdateTeam(KomodoInsuranceTeam teamToChange)
        {
            Console.WriteLine("Enter the new team name:");
            string newTeamName = Console.ReadLine();
            Console.WriteLine("Enter the new team ID:");
            int newID = int.Parse(Console.ReadLine());

            teamToChange.TeamName = newTeamName;
            teamToChange.IDNumber = newID;

            return teamToChange;
        }

        public KomodoInsuranceTeam GetTeamByID(int id)
        {
            foreach (KomodoInsuranceTeam team in _listOfTeams)
            {
                if (team.IDNumber == id)
                {
                    return team;
                }
            }
            return null;
        }

        public bool DeleteDeveloper (KomodoInsuranceDeveloper developerToRemove)
        {
            bool deleteResult = _listOfDevs.Remove(developerToRemove);
            return deleteResult;
        }

        public bool DeleteTeam(KomodoInsuranceTeam teamToRemove)
        {
            bool deleteResult = _listOfTeams.Remove(teamToRemove);
            return deleteResult;
        }

        public void DeleteTeamByID(int id)
        {
            foreach (KomodoInsuranceTeam team in _listOfTeams)
            {
                if (team.IDNumber == id)
                {
                    _listOfTeams.Remove(team);
                }
            }
        }
    }
}
