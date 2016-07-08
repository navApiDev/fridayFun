using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = minimumNumberOfCuts(100);

            Console.WriteLine("mininum number of cuts: {0}", count);
            Console.ReadLine();
        }

        private static int minimumNumberOfCuts(int stickLength)
        {
            int x = 0;
            int n = 1;
            do
            {
                x = stickLength / (stickLength / (int)Math.Pow(2, n));
                n++;
            } while (x < stickLength);
            if (stickLength % n > 0)
            {
                n++;
            }

            return n-1;
        }
    }
}
