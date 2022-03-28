using System;

namespace p;

class Program
{
    public static void Main(string[] args)
    {

        int n = 44;
            int flag = 0;

            for (int i =2; i <=44; i++)
        {
            if (44 % i == 0)
            {
                flag = 0;
                for (int j = 2; j <= i / 2; i++)

                    if (i % j == 0)
                    {
                        flag = 1;

                    }



                if (flag == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}