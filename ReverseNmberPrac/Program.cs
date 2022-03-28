using System;
namespace Reverse;

class Program
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int Reverse = 0;
        int rem;
        while (n != 0)
        {
            rem = n % 10;

            Reverse = Reverse * 10 + rem;

            n /= 10;
            Console.WriteLine(Reverse);
        }
    }
}