// See https://aka.ms/new-console-template for more information
using System;

namespace Sample
{
    enum Weekday
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
    }

    class Sample
    {
        static void Main()
        {
            foreach (Weekday day in Enum.GetValues(typeof(Weekday)))
            {
                Console.WriteLine(day);
            }
        }
    }
}