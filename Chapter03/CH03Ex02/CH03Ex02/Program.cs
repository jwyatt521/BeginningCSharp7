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
            do
            {
                string userName;
                WriteLine("Welcome to the consoleBar.NET, type your name and press \"enter\" ");
                userName = ReadLine();
                WriteLine($"What'd you do, just mash letters on the keyboard? Ok, I'll allow it (but I'm " +
                    $"watching you). So, {userName}, you're here for some alcohol.exe? Type your age and then " +
                    $"press \"enter\" ");
                int age = ToInt32(ReadLine());
                if (age >= 21)
                    WriteLine($"Let's get {userName}'s download started, eh?");
                else
                    WriteLine($"Hey {userName}, you like appleJuice.exe? " +
                        $"Get outa here with your underage self, ya bot.");

                WriteLine($"Would you like to interact with bartemder.exe again? Type:Yes or No? ");
            } while (ReadLine() == Yes);
        }
    }
}
