using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestmongThree
{
    public class Class1
    {

        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int y = Convert.ToInt32(Console.ReadLine());

            int h = Convert.ToInt32(Console.ReadLine());


            if (n > y && n > h)
            {
                Console.WriteLine(n);
            }


            else if (y > n && y > h)
            {
                Console.WriteLine(y);
            }

            else
            {
                Console.WriteLine(h);
            }
        }





    }
}
