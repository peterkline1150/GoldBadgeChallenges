using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceCustomers
{
    public class KomodoCustomer
    {
        public int IDNumber { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int NumberOfYears { get
            {
                TimeSpan ageSpan = DateTime.Now - EnrollmentDate;
                double years = ageSpan.TotalDays / 365.25;
                return Convert.ToInt32(Math.Floor(years));
            }
        }

        public KomodoCustomer()
        {

        }

        public KomodoCustomer(int idNumber, string lastName, int age, DateTime enrollmentDate)
        {
            IDNumber = idNumber;
            LastName = lastName;
            Age = age;
            EnrollmentDate = enrollmentDate;
        }
    }
}
