using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GoldBadgeChallenges
{
    [TestClass]
    public class WeekOneDayThree
    {
        string longWord = "Supercalifragilisticexpialidocious";
        [TestMethod]
        public void ChallengeDayThreePart1()
        {
            foreach (char letter in longWord)
            {
                Console.WriteLine(letter);
            }
        }
        [TestMethod]
        public void ChallengeDayThreePart2()
        {
            foreach (char letter in longWord)
            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("Not an i");
                }
            }
        }
        [TestMethod]
        public void ChallengeDayThreeBonus1()
        {
            Console.WriteLine(longWord.Length);
        }
        [TestMethod]
        public void ChallengeDayThreeBonus2()
        {
            foreach (char letter in longWord)
            {
                switch (letter)
                {
                    case 'i':
                        Console.WriteLine(letter);
                        break;
                    case 'l':
                        Console.WriteLine('L');
                        break;
                    default:
                        Console.WriteLine("Not an i or l");
                        break;
                }
            }
        }
        [TestMethod]
        public void MyTestMethod()
        {
            int NumOne = 10;
            int NumTwo = 3;
            double number;

            double Divide(int numOne, int numTwo)
            {
                double quotient = (double)numOne / numTwo;
                return quotient;
            }

            number = Divide(NumOne, NumTwo);
            Console.WriteLine(number);
        }
        [TestMethod]
        public void Random()
        {
            string name = "12345";
            int result;

            result = Int32.Parse(name);

            Console.WriteLine(result);
        }
        [TestMethod]
        public void Random2()
        {
            int NumOne = 31;
            int NumTwo = 31;
            void LargestNumber(int numOne, int numTwo)
            {
                if (numOne > numTwo)
                {
                    Console.WriteLine(numOne);
                }
                else if (numOne < numTwo)
                {
                    Console.WriteLine(numTwo);
                }
                else
                {
                    Console.WriteLine("The numbers are equal.");
                }
            }
            LargestNumber(NumOne, NumTwo);
        }
    }
}
