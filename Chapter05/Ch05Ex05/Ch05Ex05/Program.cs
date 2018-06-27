using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch05Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friendNames = { "Josiah James", "David Scott", "Hannah Jean",
                "Kristina Irene", null, "" };
            foreach (var friendName in friendNames)
            {
                switch (friendName)
                {
                    case string j when j.StartsWith("J"):
                        WriteLine($"This friends name starts with a 'J': {friendName} " +
                            $"and is {j.Length - 1} letters long ");
                        break;
                    case string e when e.Length == 0:
                        WriteLine("There is a string in the array with no value");
                        break;
                    case null:
                        WriteLine("There is a 'null' value in the array");
                        break;
                    case var x:
                        WriteLine($"This is a var pattern of type: {x.GetType().Name}");
                        break;
                    default:
                        break;
                }
            }
            int sum = 0, total = 0, counter = 0, intValue = 0;
            int?[] myIntArray = new int?[7] { 5, intValue, 9, 10, null, 2, 99 };
            foreach (var integer in myIntArray)
            {
                switch (integer)
                {
                    case 0:
                        WriteLine($"Integer number '{total}' has a value of 0");
                        counter++;
                        break;
                    case int value:
                        sum += value;
                        WriteLine($"Integer number '{total}' has a value of {value}");
                        counter++;
                        break;
                    case null:
                        WriteLine($"Integer number '{total}' is null");
                        counter++;
                        break;
                    default:
                        break;
                }
            }
            WriteLine($"{total} total integers, {counter} integers with a " +
                $"value other than 0 or null have a sum value of {sum}");
            ReadLine();
        }
    }
}