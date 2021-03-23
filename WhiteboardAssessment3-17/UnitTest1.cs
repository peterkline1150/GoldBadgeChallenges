using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WhiteboardAssessment3_17
{
    [TestClass]
    public class UnitTest1
    {
        private new WhiteBoardAssessmentClass wClass = new WhiteBoardAssessmentClass();

        [TestMethod]
        public void DeclaringVariables()
        {
            int num = 10;
            string name = "Peter";
            DateTime time = new DateTime(1990, 12, 20);
        }

        [TestMethod]
        public void SubtractingTwoNumbers()
        {
            double answer = wClass.SubtractTwoDoubles(15.5, 7.5);

            Assert.AreEqual(answer, 8);
        }

        [TestMethod]
        public void TestStringReturn()
        {
            string fullName;

            fullName = wClass.ReturnOneString("Peter", "Kline");

            Console.WriteLine(fullName);
        }

        [TestMethod]
        public void AskIfWearingClothes()
        {
            Console.WriteLine("Are you wearing clothes? yes or no: ");
            //string isWearingClothes = Console.ReadLine();
            string isWearingClothes = "yes";
            isWearingClothes = isWearingClothes.ToLower();

            switch (isWearingClothes)
            {
                case "yes":
                    Console.WriteLine("Congratulations, you are wearing clothes. Good job!!");
                    break;
                case "no":
                    Console.WriteLine("Go put some clothes on you sicko!");
                    break;
                default:
                    break;
            }
        }

        [TestMethod]
        public void SeeIfUserIsHappy()
        {
            wClass.IsUserHappy();
        }

        [TestMethod]
        public void SeeMoney()
        {
            wClass.MoneyRange();
        }
    }
}
