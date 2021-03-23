using KomodoInsuranceCustomers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceCustomer_Console
{
    class KomodoCustomerConsole
    {
        private readonly KomodoCustomerRepository _customerRepo = new KomodoCustomerRepository();
        public void Run()
        {
            Seed();
            Run_Console();
        }

        private void Run_Console()
        {
            Console.Clear();

            bool userWishesToContinue = true;

            while (userWishesToContinue)
            {
                Console.WriteLine("Welcome to the customer interface\n");

                Console.WriteLine("What would you like to do?\n" +
                    "1. Add a customer\n" +
                    "2. Remove a customer\n" +
                    "3. View all customers\n" +
                    "4. View a specific customer\n" +
                    "5. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddCustomer();
                        break;
                    case "2":
                        RemoveCustomer();
                        break;
                    case "3":
                        ViewCustomers();
                        break;
                    case "4":
                        ViewCustomerByName();
                        break;
                    case "5":
                        userWishesToContinue = false;
                        break;
                    default:
                        break;
                }
            }
        }

        private void ViewCustomerByName()
        {
            List<KomodoCustomer> listOfCustomers = _customerRepo.GetCustomers();

            Console.WriteLine("Enter the name of the customer you wish to view:");
            foreach (KomodoCustomer customer in listOfCustomers)
            {
                if (Console.ReadLine() == customer.LastName)
                {
                    Console.WriteLine($"Name: {customer.LastName}, ID: {customer.IDNumber}, Age: {customer.Age}\n");
                }
            }
        }

        private void ViewCustomers()
        {
            List<KomodoCustomer> listOfCustomers = _customerRepo.GetCustomers();

            int count = 0;
            foreach (KomodoCustomer customer in listOfCustomers)
            {
                count++;
                Console.WriteLine($"{count}:\n" +
                    $"Name: {customer.LastName}\n" +
                    $"ID: {customer.IDNumber}" +
                    $"Age: {customer.Age}\n" +
                    $"Date of Enrollment: {customer.EnrollmentDate}\n\n");
            }
        }

        private void RemoveCustomer()
        {
            Console.Clear();

            List<KomodoCustomer> listOfCustomers = _customerRepo.GetCustomers();

            Console.WriteLine("Enter the last name of the customer that you wish to delete:");
            string lastName = Console.ReadLine();

            foreach (KomodoCustomer customer in listOfCustomers)
            {
                if (customer.LastName == lastName)
                {
                    _customerRepo.DeleteCustomer(customer);
                }
            }
        }

        private void AddCustomer()
        {
            Console.Clear();

            KomodoCustomer newCustomer = new KomodoCustomer();

            Console.WriteLine("Enter the last name of the customer:");
            newCustomer.LastName = Console.ReadLine();
            Console.WriteLine("Enter the ID of the customer:");
            newCustomer.IDNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the age of the customer:");
            newCustomer.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Enrollment Date of the customer:");
            newCustomer.EnrollmentDate = DateTime.Parse(Console.ReadLine());

            _customerRepo.CreateCustomer(newCustomer);
        }

        private void Seed()
        {
            DateTime date = new DateTime(2000, 10, 10);

            KomodoCustomer customerOne = new KomodoCustomer(1, "Kline", 21, date);
            KomodoCustomer customerTwo = new KomodoCustomer(2, "Peak", 18, date);
            KomodoCustomer customerThree = new KomodoCustomer(3, "Red", 71, date);
            KomodoCustomer customerFour = new KomodoCustomer(4, "Green", 43, date);
            KomodoCustomer customerFive = new KomodoCustomer(5, "Yellow", 90, date);

            _customerRepo.CreateCustomer(customerOne);
            _customerRepo.CreateCustomer(customerTwo);
            _customerRepo.CreateCustomer(customerThree);
            _customerRepo.CreateCustomer(customerFour);
            _customerRepo.CreateCustomer(customerFive);
        }
    }
}
