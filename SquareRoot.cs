using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTesting.cs
{
    class SquareRoot
    {
        public static void sqrtRoot()
        {
            //N is the nuumber for which you are calculating squareroot
            Console.WriteLine("Enter a number");
            double N = Convert.ToDouble(Console.ReadLine());
            //set L is the tolerance level
            double L = 0.00001;
            double t = N;
            double sqRoot;
            int count = 0;
            while (true)
            {
                count++;
                sqRoot = 0.5 * (t + (N / t));
                if (Math.Abs(sqRoot - t) < L)
                {
                    break;
                }
                t = sqRoot;
            }
            Console.WriteLine("Root Value is :" + Math.Round(sqRoot, 2));
        }
    }
}