using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace doLoopPractice
{
    class DoLoopPractice
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                WriteLine("{0}", i++);
            } while (i <= 10);
            ReadKey();
        }
    }
}
