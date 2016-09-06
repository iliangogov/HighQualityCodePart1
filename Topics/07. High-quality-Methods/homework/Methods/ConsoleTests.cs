namespace Methods
{
    using System;

    public class ConsoleTests
    {
        private static void Main()
        {
            MathCalculationsClassTests();
            ConvertClassTests();
            PrintClassTests();
            StudentClassTests();
        }

        private static void MathCalculationsClassTests()
        {
            Console.WriteLine(MathCalculations.CalculateTriangleArea(3, 4, 5));
            Console.WriteLine(MathCalculations.FindMax(5, -1, 3, 2, 14, 2, 3));
            Console.WriteLine(MathCalculations.CalculateDistanceBetweenTwoPoints(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + MathCalculations.IsLineHorizontal(3, -1, 3, 2.5));
            Console.WriteLine("Vertical? " + MathCalculations.IsLineVertical(3, -1, 3, 2.5));
        }

        private static void ConvertClassTests()
        {
            Console.WriteLine(Convert.DigitToWord(5));
        }

        private static void PrintClassTests()
        {
            Print.PrintNumberInDifferentFormat(1.3, "f");
            Print.PrintNumberInDifferentFormat(0.75, "%");
            Print.PrintNumberInDifferentFormat(2.30, "r");
        }

        private static void StudentClassTests()
        {
            Student peter = new Student("Peter", "Ivanov", "Sofia", new DateTime(1992, 3, 17));
            Student stella = new Student("Stella", "Markova", "Vidin", new DateTime(1993, 3, 11));

            Console.WriteLine(
                "{0} older than {1} -> {2}",
                peter.ToString(),
                stella.ToString(),
                peter.IsOlderThan(stella));
        }
    }
}
