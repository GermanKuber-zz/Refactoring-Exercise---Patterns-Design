using System.Collections.Generic;

namespace RefactoringExercisePatternsDesign
{
    public static class IntExtension
    {
        public static IEnumerable<int> DigitsFromLowest(this long number)
        {
            do
            {
                yield return (int) number % 10;
                number /= 10;

            } while (number >0);
        }
    }
}