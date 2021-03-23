using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("yeah....");

            Console.WriteLine("How much money do you make per year?");
            double money = double.Parse(Console.ReadLine());

            if (money >= 1000 && money <= 10999)
            {
                Console.WriteLine("A little money");
            }
            else if (money >= 11000 && money <= 50999)
            {
                Console.WriteLine("A lot of money");
            }
            else if (money >= 51000 && money <= 100000)
            {
                Console.WriteLine("A TON of money");
            }
            else
            {
                Console.WriteLine("Invalid Input, not within ranges");
            }



            Console.ReadKey();
        }
    }
}
