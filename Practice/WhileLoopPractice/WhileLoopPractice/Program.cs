using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace WhileLoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10 )
            {
                WriteLine($"{i++}");
            } ReadKey();
        }
    }
}
