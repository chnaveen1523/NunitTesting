using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTesting.cs

    class MonthlyPayment
{
    //Taking user input as principal,rate of intrest , no of years
    public static void UserInput()
    {
        Console.WriteLine("Enter a principal");
        double principal = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter a interest amount ");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter a year");
        double year = Convert.ToDouble(Console.ReadLine());
        calculateMonthlyPay(principal, rate, year);
    }

    public static void calculateMonthlyPay(double principal, double rate, double year)
    {
        double s = Math.Round(1 + (rate / 1200), 4);
        double t = 12 * year;
        double monthlyPayment = principal * (Math.Pow(s, t)) - principal;
        Console.WriteLine("Monthly payment " + Math.Round(monthlyPayment));
    }
}
}