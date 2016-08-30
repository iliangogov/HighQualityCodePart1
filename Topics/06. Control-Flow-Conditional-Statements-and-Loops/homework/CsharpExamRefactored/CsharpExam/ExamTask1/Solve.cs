namespace ExamTask1
{
    using System;

    public class Solve
    {
        public static void Main()
        {
            const double MultiplyConst = 376439;
            const double DevideConst = 7;

            double treesInForrest = double.Parse(Console.ReadLine());
            double branchesOnTree = double.Parse(Console.ReadLine());
            double squirrelOnBranch = double.Parse(Console.ReadLine());
            double tailsOnSquirrel = double.Parse(Console.ReadLine());
            double totalTails = treesInForrest * branchesOnTree * squirrelOnBranch * tailsOnSquirrel;

            if (totalTails % 2 == 0)
            {
                double result = totalTails * MultiplyConst;
                Console.WriteLine("{0:0.000}", result);
            }
            else
            {
                double result = totalTails / DevideConst;
                Console.WriteLine("{0:0.000}", result);
            }
        }
    }
}
