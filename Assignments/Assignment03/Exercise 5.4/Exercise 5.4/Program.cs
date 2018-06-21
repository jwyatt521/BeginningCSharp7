using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Exercise_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Would you like to see an interesting console trick I can do? " +
                "I've been practicing for days.\nOk, you go ahead and type in a " +
                "sentence, and I'll repeat it back in reverse.");
            string myString = ReadLine();
            string reversedString = "";
            for (int i = myString.Length - 1; i >= 0; i--)
            {
                reversedString += myString[i];
            }
            WriteLine($"\nHere it is:\n{reversedString}");
            ReadKey();
        }
    }
}
