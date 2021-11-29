using System;
//Drop unsused using
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        //Drop args
        static void Main(string[] args)
        {
            string input;

            Console.WriteLine("Please enter 9 numbers without any separation:");
            input = Console.ReadLine();

            //Name Calculations.WorkingWithList is not clear as a class name
            // ISBN.PopulateCheckDigit makes more sense. 
            Console.WriteLine(string.Format("ISBN: {0}", string.Join("", Calculations.WorkingWithList(input))));

        }
    }
}
