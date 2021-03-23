using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceCustomers
{
    public class KomodoCustomerRepository
    {
        protected readonly List<KomodoCustomer> _customerDirectory = new List<KomodoCustomer>();

        //Create
        public bool CreateCustomer(KomodoCustomer customer)
        {
            int startingCount = _customerDirectory.Count();

            _customerDirectory.Add(customer);

            bool wasAdded = (_customerDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
        //Read
        public List<KomodoCustomer> GetCustomers()
        {
            return _customerDirectory;
        }

        public KomodoCustomer GetCustomerByLastName(string lastName)
        {
            foreach (KomodoCustomer customer in _customerDirectory)
            {
                if (customer.LastName == lastName)
                {
                    return customer;
                }
            }

            return null;
        }
        //Update
        public void UpdateCustomer(KomodoCustomer customerToChange)
        {
            Console.WriteLine("Enter new ID number:");
            int id = int.Parse(Console.ReadLine());
            customerToChange.IDNumber = id;

            Console.WriteLine("Enter new Last Name:");
            string lastName = Console.ReadLine();
            customerToChange.LastName = lastName;

            Console.WriteLine("Enter new age:");
            int age = int.Parse(Console.ReadLine());
            customerToChange.Age = age;

            Console.WriteLine("Enter new Enrollment Date:");
            DateTime enrollmentDate = DateTime.Parse(Console.ReadLine());
            customerToChange.EnrollmentDate = enrollmentDate;
        }
        //Delete
        public void DeleteCustomer(KomodoCustomer customerToDelete)
        {
            _customerDirectory.Remove(customerToDelete);
        }
    }
}
