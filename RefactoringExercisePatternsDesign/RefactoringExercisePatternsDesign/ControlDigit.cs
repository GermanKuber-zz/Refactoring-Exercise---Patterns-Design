using System;
using System.Collections.Generic;
using System.Linq;

namespace RefactoringExercisePatternsDesign
{
    public class ControlDigit
    {
        private readonly Func<long, IEnumerable<int>> _getDigitOf;
        private readonly IEnumerable<int> _multiplyingFactors;
        private readonly int _module;

        public ControlDigit(Func<long, IEnumerable<int>> getDigitOf,
            IEnumerable<int> multiplyingFactors, int module)
        {
            _getDigitOf = getDigitOf;
            _getDigitOf = getDigitOf;
            _multiplyingFactors = multiplyingFactors;
            _module = module;
        }
        public int GetControlDigit(long number ) =>
            _getDigitOf(number)
                .Zip(_multiplyingFactors, (a, b) => a * b)
                .Sum() % _module;
    }
}