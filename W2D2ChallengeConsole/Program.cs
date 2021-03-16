using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D2ChallengeConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            W2D2Calculator calculate = new W2D2Calculator();

            Console.WriteLine(calculate.AddNumbers(15.5, 7.2));
            Console.WriteLine(calculate.SubtractNumbers(15.5, 7.2));
            Console.WriteLine(calculate.MultiplyNumbers(15.5, 7.2));
            Console.WriteLine(calculate.DivideNumbers(15.5, 7.2));

            double sum = calculate.AddAsManyNumbersAsUserEnters();
            Console.WriteLine($"The answer is: {sum}");

            Console.ReadLine();
        }
    }
}
