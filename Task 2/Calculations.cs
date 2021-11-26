using System;
using System.Collections.Generic;

namespace Task_2
{
    class Calculations
    {
        public static List<String> WorkingWithList(String input)
        {
            var counter = 10;
            var modulusNumber = 11;
            int sumOfMultiplications = 0;

            //Adding each digit to the list
            var stringList = new List<String>();

            foreach (char c in input)
            {
                stringList.Add(c.ToString());
            }

            //Finding Check Digit
            for (int i = 0; i < stringList.Count; i++)
            {
                var multiplication = Convert.ToInt32(stringList[i]) * counter;
                counter--;
                sumOfMultiplications += multiplication;
            }

            var remainder = sumOfMultiplications % modulusNumber;
            var checkDigit = modulusNumber - remainder;

            //Applying condition to checkDigit output
            if (checkDigit == 10)
            {
                stringList.Add("X");
            }
            else
            {
                stringList.Add(Convert.ToString(checkDigit));
            }

            return stringList;
        }
    }
}
