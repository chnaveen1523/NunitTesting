using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTesting.cs
{
    class VendingMachine
    {
        public static void UserInputNotes()
        {
            Console.WriteLine("Enter the amount to get change \n(1000,500,100,50,5,2,1 available)");
            int amnt = Convert.ToInt32(Console.ReadLine());
            FewestNotes(amnt);
        }

        private static void FewestNotes(int amnt)
        {
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] count = new int[notes.Length];
            for (int i = 0; i < notes.Length; i++)
            {
                if (amnt >= notes[i])
                {
                    count[i] = amnt / notes[i];
                    amnt = amnt - (count[i] * notes[i]);
                    if (amnt < 0)
                    {
                        break;
                    }
                }
            }
            for
                (int a = 0; a < notes.Length; a++)
            {
                if (count[a] != 0)
                {
                    Console.WriteLine(+count[a] + " no of notes of rupees " + notes[a]);
                }
            }
        }
    }
}