using System;
using System.Collections.Generic;

namespace Task_2
{
    //Add internal protection modified
    class Calculations
    {
        public static List<String> WorkingWithList(String input)
        {
            var counter = 10;
            var modulusNumber = 11;
            int sumOfMultiplications = 0;

            //--> START
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
            //--> END

            //The code from --> Start to --> end could be reduced to 
            //int sumOfMultiplications = 0;
            //char[] buffer = input.ToCharArray();
            //for (int i = 0; i < 9; i++)
            //{
            //    sum += (buffer[i] - '0') * (10 - i + 1); 
            //}
           


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

            //You may return just a string "input + checkDigit", assuming that checkDigit has
            // a valid string value or 'X'.
            return stringList;
        }
    }
}
