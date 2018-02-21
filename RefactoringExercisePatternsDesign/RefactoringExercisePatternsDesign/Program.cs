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
            number
                    .DigitsFromLowest()
                        .Zip(MultiplyingFactors, (a, b) => a * b)
                        .Sum() % 7;



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


    }
}
