using System;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.WriteLine("Please enter 9 numbers without any separation:");
            input = Console.ReadLine();

            Console.WriteLine(string.Format("ISBN: {0}", string.Join("", Calculations.WorkingWithList(input))));

        }
    }
}
