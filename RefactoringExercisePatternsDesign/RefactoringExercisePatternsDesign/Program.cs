using System;
using System.Collections;
using System.Collections.Generic;

namespace RefactoringExercisePatternsDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetControlDigit(989));
        }

        static int GetControlDigit(long number)
        {
            int sum = 0;
            bool isOddPos = true;


            foreach (var digit in GetDigitsOf(number))
            {

                if (isOddPos)
                    sum += 3 * digit;
                else
                    sum += digit;
                isOddPos = !isOddPos;
            }

            int modulo = sum % 7;
            return modulo;

        }

        private static IEnumerable<int> GetDigitsOf( long number)
        {
            IList<int> digits = new List<int>();
            while (number > 0)
            {
                digits.Add((int)(number % 10));
                number /= 10;
            }

            return digits;
        }
    }
}
