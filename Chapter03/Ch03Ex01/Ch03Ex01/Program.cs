using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Ch03Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInteger;
            string myString;
            myInteger = 17;
            myString = "myInteger is";
            WriteLine($"{myString}\n {myInteger}");
            ReadKey();
        }
    }
}
