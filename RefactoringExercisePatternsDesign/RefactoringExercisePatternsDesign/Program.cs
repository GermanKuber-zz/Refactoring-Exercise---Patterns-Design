using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RefactoringExercisePatternsDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetControlDigit(989));
        }

        static int GetControlDigit(long number) =>
            GetDigitsOf(number)
                        .Zip(MultiplyingFactors, (a, b) => a * b)
                        .Sum() % 7;

        private static IList<int> GetDigitsOf(long number, IEnumerator<int> factor)
        {
            IList<int> pondereDigits = new List<int>();
            foreach (var digit in GetDigitsOf(number))
            {
                factor.MoveNext();
                pondereDigits.Add(digit * factor.Current);
            }

            return pondereDigits;
        }

        public static IEnumerable<int> MultiplyingFactors
        {
            get
            {
                int factor = 3;

                while (true)
                {
                    yield return factor;
                    factor = 4 - factor;
                }
            }
        }

        private static IEnumerable<int> GetDigitsOf(long number)
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
