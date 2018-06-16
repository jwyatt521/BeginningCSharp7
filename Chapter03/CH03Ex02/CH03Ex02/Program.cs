using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace CH03Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            string userName;
            WriteLine("Enter your name:");
            userName = ReadLine();
            WriteLine($"Welcome {userName}");
            WriteLine($"Now give me a number:");
            firstNumber = ToDouble(ReadLine());
            WriteLine("Now give me a second number:");
            secondNumber = ToDouble(ReadLine());
            WriteLine($"The sum of {firstNumber} and {secondNumber} is " +
                $"{firstNumber + secondNumber}.");
            WriteLine($"The result of subtracting {firstNumber} from " +
                $"{secondNumber} is {firstNumber - secondNumber}.");
            WriteLine($"The product of {firstNumber} and {secondNumber} is " +
                $"{firstNumber * secondNumber}.");
            WriteLine($"The result of dividing {firstNumber} by {secondNumber}" +
                $" is {firstNumber / secondNumber}.");
            WriteLine($"The remainder after dividing {firstNumber} by " +
                $"{secondNumber} is {firstNumber % secondNumber}.");
            ReadKey();
        }
    }
}
