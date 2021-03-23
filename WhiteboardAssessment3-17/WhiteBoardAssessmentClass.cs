using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardAssessment3_17
{
    class WhiteBoardAssessmentClass
    {
        public double SubtractTwoDoubles(double numOne, double numTwo)
        {
            return numOne - numTwo;
        }

        public string ReturnOneString(string stringOne, string stringTwo)
        {
            return $"{stringOne} {stringTwo}";
        }

        public bool IsUserHappy()
        {
            Console.WriteLine("Are you happy today? 1 for yes, any other integer for no:");
            //int isHappy = int.Parse(Console.ReadLine());
            int isHappy = 1;
            bool happy;

            if (isHappy == 1)
            {
                happy = true;
                Console.WriteLine("Nice, keep having a great day!");
            }
            else
            {
                happy = false;
                Console.WriteLine("I'm sorry to hear that! Hope your day gets better!");
            }
            return happy;
        }

        public void MoneyRange()
        {
            Console.WriteLine("How much money do you make per year");
            //double money = double.Parse(Console.ReadLine());
            double money = 101001;

            if (money >= 1000 && money <= 10000)
            {
                Console.WriteLine("A little money");
            }
            else if (money >= 11000 && money <= 50000)
            {
                Console.WriteLine("A lotta money");
            }
            else if (money >= 51000 && money <= 100000)
            {
                Console.WriteLine("A TON of money");
            }
            else
            {
                Console.WriteLine("Not within ranges");
            }
        }
    }
}
