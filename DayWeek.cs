using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTesting_CS
{
    class dayWeek
    {
        public static void UserInput()
        {
            Console.WriteLine("Enter the date :");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the month :");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the year :");
            int y = Convert.ToInt32(Console.ReadLine());
            CalculateDay(d, m, y);
        }

        public static void CalculateDay(int d, int m, int y)
        {
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            Console.WriteLine("1->Monday,\n2->Tuesday,\n3->Wednesday,\n4->Thursday, \n5->Friday, \n6->Saturday, \n7->Sunday");
            Console.WriteLine("Day of the given date is:" + d0);
        }
    }
}