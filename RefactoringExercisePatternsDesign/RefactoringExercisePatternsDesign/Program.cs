using System;
using System.Collections;

namespace RefactoringExercisePatternsDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ControlDigitFabric.ForAccountDepartment().GetControlDigit(989));
        }
    }
}