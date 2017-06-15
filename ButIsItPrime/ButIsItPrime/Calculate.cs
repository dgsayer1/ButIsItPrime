using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButIsItPrime
{
    public class Calculate
    {
        public bool IsThisAWholeNumber(double numberUnderTest) => numberUnderTest % 1 == 0;

        public bool IsThisAPrimeNumber(double numberUnderTest)
        {
            double numberToDivide = numberUnderTest;
            bool IsItPrime = true;

            // Easy win
            // Even numbers can be divided by 2 to make a whole number (therefore not Prime).
            if (numberUnderTest != 2)
            {
                var result = numberUnderTest / 2;
                if (IsThisAWholeNumber(result))
                {
                    IsItPrime = false;
                }
            }

            if (numberUnderTest % 2 == 0)
            {
                IsItPrime = false;
            }

            if (numberUnderTest % 3 == 0)
            {
                IsItPrime = false;
            }

            // Easy win
            // If the number ends with a 5 it's not a Prime number.
            string temp = numberUnderTest.ToString();
            string output = temp.Substring(temp.Length - 1, 1);
            if (int.Parse(output) == 5)
            {
                IsItPrime = false;
            }


            // Main calculation
            do
            {
                var result = numberUnderTest / numberToDivide;

                if (IsThisAWholeNumber(result))
                {
                    if (numberToDivide != numberUnderTest && numberToDivide != 1)
                    {
                        IsItPrime = false;
                    }
                }

                numberToDivide--;

            } while (IsItPrime && numberToDivide > 0);

            return IsItPrime;
        }
    }
}
