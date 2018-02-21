using System.Collections.Generic;

namespace RefactoringExercisePatternsDesign
{
    public static class ControlDigitFabric
    {
        public static ControlDigit ForAccountDepartment() =>
            new ControlDigit(x => x.DigitsFromLowest(),
                MultiplyingFactors, 7);
        public static ControlDigit ForSalesDepartment() =>
            new ControlDigit(x => x.DigitsFromHighest(),
                MultiplyingFactors, 7);

        private static IEnumerable<int> MultiplyingFactors
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