// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        //①
        Console.WriteLine("Hello, World!");

        //②
        string stc1 = Console.ReadLine();
        string stc2 = Console.ReadLine();

        Console.WriteLine($"{stc1}{stc2}");
    }
}