using DeveloperTeamPart1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceUI
{
    public class KomodoUI
    {
        private readonly KomodoInsuranceRepository _komodoRepository = new KomodoInsuranceRepository();

        public void Run()
        {
            //SeedContentList();
            RunContent();
        }

        private void RunContent()
        {
            bool continueToRun = true;
            while (continueToRun)
            {

                Console.Clear();
                Console.WriteLine("Choose the action you want to complete:\n" +
                    "1. Add a developer\n" +
                    "2. Add a team\n" +
                    "3. View all of the developers\n" +
                    "4. View all of the teams\n" +
                    "5. Remove a developer\n" +
                    "6. Remove a team\n" +
                    "7. Remove a developer from a team" +
                    "8. Add a developer to a team" +
                    "9. Exit");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddDeveloper();
                        break;
                    case "2":
                        AddTeam();
                        break;
                    case "3":
                        ViewDevelopers();
                        break;
                    case "4":
                        ViewTeams();
                        break;
                    case "5":
                        RemoveDeveloper();
                        break;
                    case "6":
                        RemoveTeam();
                        break;
                    case "7":
                        RemoveDevFromTeam();
                        break;
                    case "8":
                        AddDevToTeam();
                        break;
                    case "9":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number between 1 and 5\n" +
                            "Press any key to continue........");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void AddDevToTeam()
        {
            
        }

        private void RemoveDevFromTeam()
        {
            
        }

        private void RemoveTeam()
        {
            Console.Clear();

            Console.WriteLine("Which team would you like to remove?");
            List<KomodoInsuranceTeam> teams = _komodoRepository.GetTeams();
            int count = 0;
            foreach (KomodoInsuranceTeam team in teams)
            {
                count++;
                Console.WriteLine($"{count}: {team.TeamName}");
            }

            int targetID = int.Parse(Console.ReadLine());
            int targetIndex = targetID - 1;

            if (targetIndex >= 0 && targetIndex < teams.Count)
            {
                KomodoInsuranceTeam targetedTeam = teams[targetIndex];

                if (_komodoRepository.DeleteTeam(targetedTeam))
                {
                    Console.WriteLine($"{targetedTeam.TeamName} was successfully removed");
                }
                else
                {
                    Console.WriteLine("I can't do that");
                }
            }
            else
            {
                Console.WriteLine("Not a valid team");
            }
            Console.WriteLine("Press any key to continue.....");
            Console.ReadKey();
        }

        private void RemoveDeveloper()
        {
            Console.Clear();

            Console.WriteLine("Which developer would you like to remove?");
            List<KomodoInsuranceDeveloper> devs = _komodoRepository.GetDevs();
            int count = 0;
            foreach (KomodoInsuranceDeveloper developer in devs)
            {
                count++;
                Console.WriteLine($"{count}: {developer.LastName}");
            }

            int targetID = int.Parse(Console.ReadLine());
            int targetIndex = targetID - 1;

            if (targetIndex >= 0 && targetIndex < devs.Count)
            {
                KomodoInsuranceDeveloper targetedDev = devs[targetIndex];

                if (_komodoRepository.DeleteDeveloper(targetedDev))
                {
                    Console.WriteLine($"{targetedDev.LastName} was successfully removed");
                }
                else
                {
                    Console.WriteLine("I can't do that");
                }
            }
            else
            {
                Console.WriteLine("Not a valid developer");
            }
            Console.WriteLine("Press any key to continue.....");
            Console.ReadKey();
        }

        private void ViewTeams()
        {
            Console.Clear();

            List<KomodoInsuranceTeam> teams = _komodoRepository.GetTeams();
            foreach (KomodoInsuranceTeam team in teams)
            {
                DisplayTeam(team);
            }

            Console.WriteLine("Press any key to continue.....");
            Console.ReadKey();
        }

        private void DisplayTeam(KomodoInsuranceTeam team)
        {
            Console.WriteLine($"Team Name: {team.TeamName}\n" +
                $"Team ID: {team.IDNumber}\n");

            Console.WriteLine("Members of the team:\n");
            int count = 0;
            foreach (KomodoInsuranceDeveloper developer in team.Developers)
            {
                count++;
                Console.WriteLine($"{count}: {developer.LastName}\n");
            }
        }

        private void ViewDevelopers()
        {
            Console.Clear();

            List<KomodoInsuranceDeveloper> devs = _komodoRepository.GetDevs();
            foreach (KomodoInsuranceDeveloper developer in devs)
            {
                DisplayDev(developer);
            }

            Console.WriteLine("Press any key to continue.....");
            Console.ReadKey();
        }

        private void DisplayDev(KomodoInsuranceDeveloper dev)
        {
            Console.WriteLine($"Name: {dev.LastName}\n" +
                $"ID Number: {dev.DeveloperID}\n" +
                $"Has Access: {dev.HasAccess}");
        }

        private void AddTeam()
        {
            Console.Clear();
            _komodoRepository.CreateTeams();

            Console.WriteLine("Press any key to continue.....");
            Console.ReadKey();
        }

        private void AddDeveloper()
        {
            Console.Clear();

            _komodoRepository.CreateDeveloper();

            Console.WriteLine("Press any key to continue.....");
            Console.ReadKey();
        }
    }
}
