using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D2ChallengeConsole
{
    public class W2D2Calculator
    {
        public double AddNumbers(double num1, double num2)
        {
            return num1 + num2;
        }

        public double SubtractNumbers(double num1, double num2)
        {
            return num1 - num2;
        }

        public double MultiplyNumbers(double num1, double num2)
        {
            return num1 * num2;
        }

        public double DivideNumbers(double num1, double num2)
        {
            return num1 / num2;
        }

        public double AddAsManyNumbersAsUserEnters()
        {
            double sum = 0;
            int numberOfNumbers;

            Console.WriteLine("Enter the amount of numbers you want to add:");
            numberOfNumbers = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfNumbers; i++)
            {
                Console.WriteLine("Enter a Number:");
                double numberEntered = Convert.ToDouble(Console.ReadLine());
                sum += numberEntered;
            }
            return sum;
        }
    }
}
