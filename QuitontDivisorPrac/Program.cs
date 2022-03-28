using System;

namespace Qui;

class Program
{
    public static void Main(string[]args)
    {
        int Divi = 50;
        int divisor = 5;

        int Quit = Divi / divisor;
        int Remin = Divi % divisor;
        Console.WriteLine( Remin);
        Console.WriteLine(Quit);
    }
}
