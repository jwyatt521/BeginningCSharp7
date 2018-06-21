using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Exercise_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello User, this is Master Control. Would you like " +
                "to join the gaming arena? (type \"yes\" or \"no\")");
            string myString = ReadLine();
            myString = myString.Replace("no", "yes");
            WriteLine($"User input: {myString}\nInitiating Request...");
            ReadKey();
        }
    }
}
