namespace Methods
{
    using System;

    internal class Print
    {
        internal static void PrintNumberInDifferentFormat(double number, string format)
        {
            switch (format)
            {
                case "f":
                    Console.WriteLine("{0:f2}", number);
                    break;

                case "%":
                    Console.WriteLine("{0:p0}", number);
                    break;

                case "r":
                    Console.WriteLine("{0,8}", number);
                    break;

                default:
                    throw new ArgumentException("invalid format.");
            }
        }
    }
}
