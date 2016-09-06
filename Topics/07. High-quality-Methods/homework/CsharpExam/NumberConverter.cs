namespace CsharpExam
{
    using System.Numerics;

    internal class NumberConverter
    {
        internal static BigInteger TwentySixBasedNumberToDecimalNumber(string number)
        {
            BigInteger result = 0;
            BigInteger toBase = 26;

            foreach (char ch in number)
            {
                result = (BigInteger)(ch - 'a') + (result * toBase);
            }

            return result;
        }

        internal static BigInteger SevenBasedNumberToDecimalNumber(string str)
        {
            BigInteger decimalNumber = 0;
            BigInteger power = 1;
            BigInteger fromBase = 7;

            for (int i = 0; i < str.Length; i++)
            {
                decimalNumber += BigInteger.Parse(str[str.Length - 1 - i].ToString()) * power;
                power *= fromBase;
            }

            return decimalNumber;
        }

        internal static string DecimalNumberToNineBasedNumber(BigInteger number)
        {
            string str = string.Empty;
            BigInteger toBase = 9;

            while (number > 0)
            {
                str = (number % toBase) + str;
                number /= toBase;
            }

            return str;
        }
    }
}
