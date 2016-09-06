namespace CryptoCs
{
    using System;
    using System.Numerics;
    using CsharpExam;

    internal class Solution
    {
        public static void Main()
        {
            string twentySixBasedNumberAsString = Console.ReadLine();
            string operationSign = Console.ReadLine();
            string sevenBasedNumberAsString = Console.ReadLine();

            BigInteger sum = 0;

            if (operationSign.Contains("+"))
            {
                sum = NumberConverter.TwentySixBasedNumberToDecimalNumber(twentySixBasedNumberAsString) 
                    + NumberConverter.SevenBasedNumberToDecimalNumber(sevenBasedNumberAsString);
            }

            if (operationSign.Contains("-"))
            {
                sum = NumberConverter.TwentySixBasedNumberToDecimalNumber(twentySixBasedNumberAsString) 
                    - NumberConverter.SevenBasedNumberToDecimalNumber(sevenBasedNumberAsString);
            }

            Console.WriteLine(NumberConverter.DecimalNumberToNineBasedNumber(sum));
        }
    }
}
