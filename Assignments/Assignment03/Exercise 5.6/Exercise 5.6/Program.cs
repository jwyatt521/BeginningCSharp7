using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Exercise_5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("I'm a quotation program. I take each word in a string and surround " +
                "it with double quotes like \"this\".\nLet's give it a go. Enter in a multi-word string:");
            string myString = ReadLine();
            myString = "\"" + myString.Replace(" ", "\" \"") + "\"";
            WriteLine($"I added some double quotes around that for you:\n{myString}");
            ReadKey();
        }
    }
}
