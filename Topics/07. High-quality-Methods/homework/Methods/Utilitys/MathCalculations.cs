namespace Methods
{
    using System;

    internal class MathCalculations
    {
        internal static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentNullException("Sides should be positive.");
            }

            if (a > (b + c) || b > (a + c) || c > (a + b))
            {
                throw new ArgumentException("these Side's sizes can not form a triangle.");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            if (s > double.MaxValue || area > double.MaxValue)
            {
                throw new ArgumentOutOfRangeException("sides", "are too big to be proper calculted.");
            }

            return area;
        }

        internal static int FindMax(params int[] elements)
        {
            int maxElement = elements[0];

            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("Invalid int array provided.");
            }

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxElement)
                {
                    maxElement = elements[i];
                }
            }

            return maxElement;
        }

        internal static double CalculateDistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        internal static bool IsLineHorizontal(double startpointX, double startpointY, double endpointX, double endpointY)
        {
            bool isLine = startpointX != endpointX || startpointY != endpointY;
            bool isHorizontalLine = startpointY == endpointY;

            return isLine && isHorizontalLine;
        }

        internal static bool IsLineVertical(double startpointX, double startpointY, double endpointX, double endpointY)
        {
            bool isLine = startpointX != endpointX || startpointY != endpointY;
            bool isVertical = startpointX == endpointX;

            return isLine && isVertical;
        }
    }
}
