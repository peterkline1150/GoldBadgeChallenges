using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D2_Challenge
{
    public class Calculator
    {
        public int AddNumbers(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }
        public double AddNumbers(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }

        public int SubtractNumbers(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }
        public double SubtractNumbers(double numOne, double numTwo)
        {
            return numOne - numTwo;
        }

        public int MultiplyNumbers(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }
        public double MultiplyNumbers(double numOne, double numTwo)
        {
            return numOne * numTwo;
        }

        public int DivideNumbers(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }
        public double DivideNumbers(double numOne, double numTwo)
        {
            return numOne / numTwo;
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
    [TestClass]
    public class CalculatorTestClass
    {
        readonly private double numOne = 1.5;
        readonly private double numTwo = 2.6;
        readonly private int numThree = 27;
        readonly private int numFour = 3;
        readonly Calculator calculate = new Calculator();
        [TestMethod]
        public void TestingAdditionMethodShouldReturnTrue()
        {
            var sum = calculate.AddNumbers(numThree, numFour);
            var sumTwo = calculate.AddNumbers(numOne, numTwo);

            var testSum = numThree + numFour;
            var testSumTwo = numOne + numTwo;

            Assert.AreEqual(sum, testSum);
            Assert.AreEqual(sumTwo, testSumTwo);

            Console.WriteLine(sum);
            Console.WriteLine(testSum);
            Console.WriteLine(sumTwo);
            Console.WriteLine(testSumTwo);
        }
        [TestMethod]
        public void TestingMultiplicationMethodShouldReturnTrue()
        {
            var mult = calculate.MultiplyNumbers(numThree, numFour);
            var multTwo = calculate.MultiplyNumbers(numOne, numTwo);

            var testMult = numThree * numFour;
            var testMultTwo = numOne * numTwo;

            Assert.AreEqual(mult, testMult);
            Assert.AreEqual(multTwo, testMultTwo);

            Console.WriteLine(mult);
            Console.WriteLine(testMult);
            Console.WriteLine(multTwo);
            Console.WriteLine(testMultTwo);
        }
        [TestMethod]
        public void TestingSubtractionMethodShouldReturnTrue()
        {
            var sub = calculate.SubtractNumbers(numThree, numFour);
            var subTwo = calculate.SubtractNumbers(numOne, numTwo);

            var testSub = numThree - numFour;
            var testSubTwo = numOne - numTwo;

            Assert.AreEqual(sub, testSub);
            Assert.AreEqual(subTwo, testSubTwo);

            Console.WriteLine(sub);
            Console.WriteLine(testSub);
            Console.WriteLine(subTwo);
            Console.WriteLine(testSubTwo);
        }
        [TestMethod]
        public void TestingDivisionMethodShouldReturnTrue()
        {
            double divide = calculate.DivideNumbers(numOne, numTwo);

            Assert.AreEqual(divide, (numOne / numTwo));
        }
    }
}
