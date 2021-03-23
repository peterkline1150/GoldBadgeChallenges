using KomodoInsuranceDevelopersAndTeams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceDevelopersAndTeams_Console
{
    public class Komodo_Console
    {
        private readonly KomodoDevRepo _komodorepo = new KomodoDevRepo();

        public void Run()
        {
            Seed();
            ShowInterface();
        }

        private void ShowInterface()
        {
            bool continueToRun = true;

            while (continueToRun)
            {
                Console.Clear();

                Console.WriteLine("Welcome to the Komodo Insurance Developer and Team Management Software!\n\n");

                Console.WriteLine("Choose what option you want to do:\n" +
                    "1. Add a developer\n" +
                    "2. Add a team\n" +
                    "3. Add a developer to a team\n" +
                    "4. Remove a developer from a team\n" +
                    "5. Show all existing teams\n" +
                    "6. Show all existing Developers\n" +
                    "7. Show a team by its ID\n" +
                    "8. Show a Developer by his/her ID\n" +
                    "9. Delete a team\n" +
                    "10. Delete a developer\n" +
                    "11. Exit");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddDev();
                        break;
                    case "2":
                        AddTeam();
                        break;
                    case "3":
                        AddDevToTeam();
                        break;
                    case "4":
                        RemoveDevFromTeam();
                        break;
                    case "5":
                        ShowTeams();
                        break;
                    case "6":
                        ShowDevs();
                        break;
                    case "7":
                        ShowTeamByID();
                        break;
                    case "8":
                        ShowDevByID();
                        break;
                    case "9":
                        DeleteTeam();
                        break;
                    case "10":
                        DeleteDev();
                        break;
                    case "11":
                    default:
                        continueToRun = false;
                        break;
                }
            }
        }

        private void DeleteTeam()
        {
            Console.Clear();

            DisplayTeams();

            List<KomodoTeam> teams = _komodorepo.GetTeams();

            Console.WriteLine("Which number team would you like to delete?:");

            int userID = int.Parse(Console.ReadLine());
            int userIndex = userID - 1;

            if (userIndex >= 0 && userIndex < teams.Count)
            {
                _komodorepo.DeleteTeam(teams[userIndex]);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            PressAnyKey();
        }

        private void DeleteDev()
        {
            Console.Clear();

            DisplayDevs();

            List<KomodoDeveloper> devs = _komodorepo.GetDevs();

            Console.WriteLine("Enter the number of the developer you wish to delete:");

            int userID = int.Parse(Console.ReadLine());
            int userIndex = userID - 1;

            if (userIndex >= 0 && userIndex < devs.Count)
            {
                _komodorepo.DeleteDeveloper(devs[userIndex]);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            PressAnyKey();
        }

        private void ShowDevByID()
        {
            Console.Clear();

            Console.WriteLine("Enter the ID of the Developer you want to view:");

            int id = int.Parse(Console.ReadLine());

            KomodoDeveloper developer = _komodorepo.GetDeveloperByID(id);

            Console.WriteLine($"Developer ID: {developer.DeveloperID}\n" +
                $"Developer Last Name: {developer.LastName}\n" +
                $"Has Access: {developer.HasAccess}\n");

            PressAnyKey();
        }

        private void ShowTeamByID()
        {
            Console.Clear();

            Console.WriteLine("Enter the ID of the team you want to view:");

            int id = int.Parse(Console.ReadLine());

            KomodoTeam team = _komodorepo.GetTeamByID(id);

            Console.WriteLine($"Team Name: {team.TeamName}\n" +
                $"Team ID Number: {team.IDNumber}\n");
            foreach (KomodoDeveloper developer in team.Developers)
            {
                Console.WriteLine($"Developer: {developer.LastName}");
            }

            PressAnyKey();
        }

        private void RemoveDevFromTeam()
        {
            Console.Clear();

            Console.WriteLine("Choose which team to remove a dev from:");

            DisplayTeams();

            List<KomodoTeam> teams = _komodorepo.GetTeams();

            int userID = int.Parse(Console.ReadLine());
            int userIndex = userID - 1;
            if (userIndex >= 0 && userIndex < teams.Count)
            {
                Console.Clear();

                Console.WriteLine("Which dev do you want to remove from this team?");

                int count = 0;
                foreach (KomodoDeveloper developer in teams[userIndex].Developers)
                {
                    count++;
                    Console.WriteLine($"{count}: {developer.LastName}");
                }

                int userID2 = int.Parse(Console.ReadLine());
                int userIndex2 = userID2 - 1;

                if (userIndex2 >= 0 && userIndex2 < teams[userIndex].Developers.Count)
                {
                    teams[userIndex].DeleteDeveloper(teams[userIndex].Developers[userIndex2]);
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                }
            }

            PressAnyKey();
        }

        private void AddDevToTeam()
        {
            Console.Clear();

            Console.WriteLine("Choose which team to add a dev to:");

            DisplayTeams();

            List<KomodoTeam> teams = _komodorepo.GetTeams();

            int userID = int.Parse(Console.ReadLine());
            int userIndex = userID - 1;

            if (userIndex >= 0 && userIndex < teams.Count)
            {
                Console.Clear();

                Console.WriteLine("Which dev do you wish to add?");

                DisplayDevs();

                List<KomodoDeveloper> devs = _komodorepo.GetDevs();

                int userID2 = int.Parse(Console.ReadLine());
                int userIndex2 = userID2 - 1;

                if (userIndex2 >= 0 && userIndex2 < devs.Count)
                {
                    teams[userIndex].AddDeveloper(devs[userIndex2]);
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            PressAnyKey();
        }

        private void ShowTeams()
        {
            Console.Clear();

            DisplayTeams();

            PressAnyKey();
        }

        private void ShowDevs()
        {
            Console.Clear();

            DisplayDevs();

            PressAnyKey();
        }

        private void AddTeam()
        {
            Console.Clear();

            KomodoTeam newTeam = new KomodoTeam();

            Console.WriteLine("Enter the ID number of the new team:");
            newTeam.IDNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Name of the new team:");
            newTeam.TeamName = Console.ReadLine();

            bool userWishesToContinue = true;

            while (userWishesToContinue)
            {
                List<KomodoDeveloper> listOfDevs = _komodorepo.GetDevs();

                Console.WriteLine("Enter the number of the developer you with to add to the team:");

                int count = 0;
                foreach (KomodoDeveloper dev in listOfDevs)
                {
                    count++;
                    Console.WriteLine($"{count}: {dev.LastName}");
                }

                int choice = int.Parse(Console.ReadLine());
                if (choice > 0 && choice <= listOfDevs.Count)
                {
                    newTeam.AddDeveloper(listOfDevs[choice - 1]);
                }

                Console.WriteLine("Do you want to continue to add members to your team? (y/n)");
                string continueToAdd = Console.ReadLine();
                if (continueToAdd == "y")
                {
                    userWishesToContinue = true;
                }
                else
                {
                    userWishesToContinue = false;
                }
            }

            _komodorepo.AddTeam(newTeam);

            PressAnyKey();
        }

        private void AddDev()
        {
            Console.Clear();
            
            KomodoDeveloper newDev = new KomodoDeveloper();

            Console.WriteLine("Enter the ID number of the new developer:");
            newDev.DeveloperID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Last Name of the new developer:");
            newDev.LastName = Console.ReadLine();
            Console.WriteLine("Does the Developer have access? (y/n)");
            string access = Console.ReadLine();
            if (access == "y")
            {
                newDev.HasAccess = true;
            }
            else
            {
                newDev.HasAccess = false;
            }

            _komodorepo.AddDeveloper(newDev);

            PressAnyKey();
        }

        private void DisplayDevs()
        {
            List<KomodoDeveloper> listOfDevs = _komodorepo.GetDevs();

            int count = 0;
            foreach (KomodoDeveloper developer in listOfDevs)
            {
                count++;
                Console.WriteLine($"Developer #{count}:\n" +
                    "-------------------------\n" +
                    $"ID: {developer.DeveloperID}\n" +
                    $"Name: {developer.LastName}\n" +
                    $"Has access: {developer.HasAccess}\n");
            }
        }

        private void DisplayTeams()
        {
            List<KomodoTeam> listOfTeams = _komodorepo.GetTeams();

            int count = 0;
            foreach (KomodoTeam team in listOfTeams)
            {
                count++;
                Console.WriteLine($"Team #{count}:\n" +
                    "-------------------------\n" +
                    $"Team ID: {team.IDNumber}\n" +
                    $"Team Name: {team.TeamName}\n");

                foreach (KomodoDeveloper developer in team.Developers)
                {
                    Console.WriteLine($"Member: {developer.LastName}\n");
                }
            }
        }

        private void PressAnyKey()
        {
            Console.WriteLine("Press any key to continue.....");
            Console.ReadKey();
        }

        private void Seed()
        {
            KomodoDeveloper dev1 = new KomodoDeveloper(1, "Kline", true);
            KomodoDeveloper dev2 = new KomodoDeveloper(2, "Peak", true);
            KomodoDeveloper dev3 = new KomodoDeveloper(3, "yes", true);
            KomodoDeveloper dev4 = new KomodoDeveloper(4, "fgdfgd", true);
            KomodoDeveloper dev5 = new KomodoDeveloper(5, "Blue", true);

            List<KomodoDeveloper> devsForTeam1 = new List<KomodoDeveloper>();
            devsForTeam1.Add(dev1);
            devsForTeam1.Add(dev2);
            devsForTeam1.Add(dev3);

            List<KomodoDeveloper> devsForTeam2 = new List<KomodoDeveloper>();
            devsForTeam2.Add(dev4);
            devsForTeam2.Add(dev5);

            KomodoTeam team1 = new KomodoTeam(devsForTeam1, 1, "best");
            KomodoTeam team2 = new KomodoTeam(devsForTeam2, 2, "around");

            _komodorepo.AddDeveloper(dev1);
            _komodorepo.AddDeveloper(dev2);
            _komodorepo.AddDeveloper(dev3);
            _komodorepo.AddDeveloper(dev4);
            _komodorepo.AddDeveloper(dev5);

            _komodorepo.AddTeam(team1);
            _komodorepo.AddTeam(team2);
        }
    }
}
