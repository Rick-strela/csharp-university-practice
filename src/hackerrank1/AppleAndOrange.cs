using System;
using System.Collections.Generic;

namespace AppleAndOrange
{
    public class Result
    {
        public static (int, int) GetCounts(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int appleCount = 0;
            int orangeCount = 0;

            foreach (int apple in apples)
            {
                int pos = a + apple;
                if (pos >= s && pos <= t) appleCount++;
            }

            foreach (int orange in oranges)
            {
                int pos = b + orange;
                if (pos >= s && pos <= t) orangeCount++;
            }

            return (appleCount, orangeCount);
        }

        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            var (appleCount, orangeCount) = GetCounts(s, t, a, b, apples, oranges);
            Console.WriteLine(appleCount);
            Console.WriteLine(orangeCount);
        }
    }
}