using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; ++i)
            {
                WriteLine($"{i}");
            } ReadKey();
        }
    }
}
