namespace ExamTask2
{
    using System;

    public class Solve
    {
        public static void Main()
        {
            int carsCount = int.Parse(Console.ReadLine());
            int currentSpeed = 0;
            int sumOfSpeeds = 0;
            int groupCount = 0;
            int biggestCount = 0;
            int bestSpeedsSum = 0;

            for (int i = 1; i <= carsCount; i++)
            {
                int newSpeed = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    currentSpeed = newSpeed;
                    sumOfSpeeds = newSpeed;
                    groupCount = 1;
                }
                else
                {
                    if (newSpeed > currentSpeed)
                    {
                        sumOfSpeeds += newSpeed;
                        groupCount++;
                    }
                    
                    if (newSpeed == currentSpeed)
                    {
                        groupCount = 1;
                        sumOfSpeeds = newSpeed;
                    }

                    if (newSpeed < currentSpeed)
                    {
                        groupCount = 1;
                        currentSpeed = newSpeed;
                        sumOfSpeeds = newSpeed;
                    }
                }

                if (groupCount > biggestCount)
                {
                    biggestCount = groupCount;
                    bestSpeedsSum = sumOfSpeeds;
                }

                if ((groupCount == biggestCount) && (sumOfSpeeds > bestSpeedsSum))
                {
                    biggestCount = groupCount;
                    bestSpeedsSum = sumOfSpeeds;
                }
            }

            Console.WriteLine(bestSpeedsSum);
        }
    }
}
