namespace ExamTask3
{
    using System;

    public class Solution
    {
        public static void Main()
        {
            int from = int.Parse(Console.ReadLine());
            int to = int.Parse(Console.ReadLine());
            int smaller = Math.Min(from, to);
            int bigger = Math.Max(from, to);
            from = smaller;
            to = bigger;
            long sum = 0;

            for (int i = from; i <= to; i++)
            {
                for (int j = 1; j <= i; j += 2)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
