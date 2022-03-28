using System;

namespace LeapYearPrac;

class Program
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        if(n%4==0 && n%100!=0 || (n%400==0))
        {
            Console.WriteLine("Leap Year");
        }

        else
        {
            Console.WriteLine("not Leap Year");
        }
            
                
    }
}