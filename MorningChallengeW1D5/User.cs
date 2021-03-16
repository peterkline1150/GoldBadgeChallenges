using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MorningChallengeW1D5
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; }
        public DateTime BirthDate { get; set; }
        public User()
        {

        }
        public User(string firstName, string lastName, int id, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            BirthDate = birthDate;
        }
        public string GetFullName()
        {
            string fullName = $"{FirstName} {LastName}";
            return fullName;
        }
        public int AgeOfUserInYears()
        {
            TimeSpan ageSpan = DateTime.Now - BirthDate;
            double ageInYears = ageSpan.TotalDays / 365.25;
            int age = Convert.ToInt32(Math.Floor(ageInYears));
            return age;
        }
    }
}
