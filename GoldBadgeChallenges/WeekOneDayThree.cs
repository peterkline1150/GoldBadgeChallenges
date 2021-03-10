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
    }
}
